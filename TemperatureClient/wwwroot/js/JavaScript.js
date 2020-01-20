 /*   Copyright(r) Slettebakk.com, 2019
    Developed by Jann Slettebakk, SCDS
<head>
    <title>Heating system overvire - Ospestien 51</title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js"></script>
    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
    <link href="css/VPstyles.css" rel="stylesheet" type="text/css">
    <link rel="shortcut icon" href="">
</head>

<body>
    <!-- <div class='load'></div> -->
    <div id="IntroTop"></div>
    <div id ="DayDashboard">
        <!-- <div class="load.stop"></div> -->
        <div id="filterDay"></div>
        <div id="chartDay"></div>
    </div>
    <div id="IdChartAll"></div>

<script type="text/javascript">
*/
// Visualization API with the 'corechart' package.
// google.charts.load('visualization', { packages: ['corechart','controls'] });
google.charts.load('current', { packages: ['corechart','controls'] });
google.charts.setOnLoadCallback(drawLineChart);
// fixed varibles
var dataLogsPerDay = 300; // Samples visualised pr. day (estimated )
var displayData = 5000; // Viser bare XXXXX records i graphen

function drawLineChart() {
    $.ajax({
        url: "https://smarthouseapi.slettebakk.com/api/TemperatureSensors?number=" + displayData,
        dataType: "json",
        type: "GET",
        success: function (data) {


            // Input JSON
            // ...
            // },
            // {
            //    "temperatureId": "f493aa0a-568d-49b8-8255-b7128f47d50f",
            //    "sensorTankTimeStamp": "2019-05-17T16:57:39",
            //    "sensorTankTemp": 34.88,
            //    "sensorVpTurTemp": 27.75,
            //    "sensorVpReturTemp": 27.31,
            //    "sensorGulvReturTankTemp": 30.56,
            //    "sensorGulvTurTankTemp": 32.25,
            //    "sensorACVannReservoar": 0.00,
            //    "indorTemperature" : 21.45,
            //    "outdorTemperature" : -0.5
            //  },
            //  {
            //  ...


            // Define the arrayes and assign columns for the chart
            var TemperatureArrayDisplay = [['sensorTankTimeStamp', 'Tank Tmp.','VP Tur','VP Retur','Gulv Tur', 'Gulv Retur', 'Indoor', 'Outdoor']];
            var TemperatureArrayDay = [['sensorTankTimeStamp', 'Tank Tmp.','VP Tur','VP Retur','Gulv Tur', 'Gulv Retur', 'Indoor', 'Outdoor']];

            // console.log( "Data length:" , data.length, " Date in json", data);
            // console.log("Outside .ajax. Value content :", data, "og har ", data.length, "elementer");

            // Loop through each data and populate the array.
            var n = Math.min(data.length, displayData);
            for ( var i = 1; i<n; i++) {
                TemperatureArrayDisplay.push([
                    new Date(data[i].sensorTankTimeStamp),
                    data[i].sensorTankTemp,
                    data[i].sensorVpTurTemp,
                    data[i].sensorVpReturTemp,
                    data[i].sensorGulvTurTankTemp,
                    data[i].sensorGulvReturTankTemp,
                    data[i].indorTemperature,
                    data[i].outdorTemperature
                ]);
            }

            console.log( "Data length:" ,TemperatureArrayDisplay.length, "Data content:" , TemperatureArrayDisplay);


            // Copy TemperatureArrayDisplay to a shorter table (day view)
            n = Math.min(dataLogsPerDay,TemperatureArrayDisplay.length);
            for (i=1; i<n; i++) {
                // console.log("Records [",data.length-n+i,"] :", data[data.length-n+i-1].timeStamp, data[data.length-n+i-1].temperature);
                TemperatureArrayDay.push(TemperatureArrayDisplay[i]);
            }

            // console.log( "DataDay length:" ,TemperatureArrayDay.length, "Data content:" , TemperatureArrayDay);

            var first =  new Date(TemperatureArrayDay[1][0]).getTime();
            var last = new Date(TemperatureArrayDay[TemperatureArrayDay.length-1][0]).getTime();
            var dayHoursDiff = Math.floor((first - last)/(1000*60*60) % 24);
            var dayMinutesDiff = Math.floor((first - last)/(1000*60) % 60);

            // console.log("First =", first);
            // console.log("Last =", last);
            // console.log (" timer =", dayHoursDiff, " Minutter=", dayMinutesDiff)



            first = new Date(TemperatureArrayDisplay[1][0]).getTime();
            last = new Date(TemperatureArrayDisplay[TemperatureArrayDisplay.length - 1][0]).getTime();

            var diffInSeconds = Math.abs(first - last) / 1000;
            var displayDays = Math.floor(diffInSeconds / 60 / 60 / 24);
            var displayHours = Math.floor(diffInSeconds / 60 / 60 % 24);
            var displayMinutes = Math.floor(diffInSeconds / 60 % 60);

            // TemperatureArrayDisplay

            // console.log("Outside .ajax. Number of elements :", data.length);
            // console.log("\nTemperatureArrayDisplay i .ajax :\n",TemperatureArrayDisplay);
            // console.log("\nTemperatureArrayDay i .ajax :\n",TemperatureArrayDay);

            // Set chart Options.
            var drawTemperatureAllOption = {
                chartType: 'LineChart',
                curveType: 'function',
                containerId: 'IdChartAll',
                dataTable: TemperatureArrayDisplay,
                width: '100%',
                height: '100%',
                legend: {
                    position: 'bottom',
                    textStyle: {
                        color: '#555',
                        fontSize: 12
                        }
                    },  // You can position the legend on 'top' or at the 'bottom'.
                lineWidth: 0.6,
                title: 'Long report (around ' + displayDays + '  days and ' + displayHours + ' hrs) overview.',
                lineText: 'value',
                hAxis: {
                    format: 'dd.MMM/\nyyyy',
                    textStyle:  { color: '#555', fontSize: 12}
                    }
            };
                
            // Create a range slider, passing some options
            var optionsDaySlider = new google.visualization.ControlWrapper({
                controlType: 'DateRangeFilter',
                containerId: 'filterDay',
                fontSize: 12,
                options: {
                    title: 'Date filter',
                    textStyle:  { color: '#555', fontSize: 12},
                    filterColumnLabel: 'sensorTankTimeStamp',
                    ui : { label: 'Date/time',
                            format: {
                                pattern: 'HH:mm' // 'M/d hh:mm'
                                },
                            step: 'minutes'
                            }
                }
            });

                    // Create a line chart, passing some options
            var drawDayLineChartOptions = new google.visualization.ChartWrapper({
                chartType: 'LineChart',
                curveType: 'function',
                containerId: 'chartDay',
                dataTable: TemperatureArrayDay,
                options: {
                    title: 'Short data overview (around ' + dayHoursDiff + '  hrs and ' + dayMinutesDiff + ' minutes) with slider.',
                    width: '100%',
                    height: '100%',
                    lineText: 'value',
                    lineWidth: 1,
                    legend: {
                        position: 'bottom',
                        textStyle: {
                            color: '#555',
                            fontSize: 12
                            }
                        },  // You can position the legend on 'top' or at the 'bottom'.
                    hAxis: {
                        format: 'HH:mm\nd/M/yy',
                        textStyle: {
                            color: '#555',
                            fontSize: 12
                            }
                        // formatType: 'short'
                    }
            }
            });

            // Create DataTable and add the array to it.
            var TemperatureDisplay = google.visualization.arrayToDataTable(TemperatureArrayDisplay);
            var TemperatureDay = google.visualization.arrayToDataTable(TemperatureArrayDay);

            // Date formatting
            var dateFormatterDay = new google.visualization.DateFormat({
                formatType: 'short',
                pattern: 'HH:mm:ss'
                });
            var dateFormatterAll = new google.visualization.DateFormat({
                formatType: 'long',
                pattern: 'YYYY/MM/dd HH:mm:ss'
                });
                    
            dateFormatterDay.format(TemperatureDay, 0);
            dateFormatterAll.format(TemperatureDisplay, 0);

            // Create a 'Day' dashboard.
            var dayDashboard = new google.visualization.Dashboard(document.getElementById('dayDashboard'));

            // console.log("\nTemperatureDay :\n",TemperatureDay);

            dayDashboard.bind(optionsDaySlider, drawDayLineChartOptions);

            // Draw the dashboard.
            dayDashboard.draw(TemperatureDay, drawDayLineChartOptions);

            // Define the chart type (LineChart) and the container (a DIV in our case).
            var allDataChart = new google.visualization.LineChart(document.getElementById('IdChartAll'));

            allDataChart.draw(TemperatureDisplay, drawTemperatureAllOption);      // Draw the chart with Options.

            var dataBaseAlive = 'Database: <span class="dotGreen"></span> ';
            var raspberryAlive = ' Raspberry:  <span class="dotGreen"></span>';

            // Indicate helth of database access
            if ( data.length < 1) dataBaseAlive = 'Database:<span class="dotRed"></span> '; // database dead?
            // indicate helth of raspberry
                var lastPoll = TemperatureDisplay.getValue(1, 0);
                // 1 dag i ms = 24*60*60*1000 = 86400000, 1 time i ms = 1*60*60*1000 = 3600000
                var onerHrInMs =  1*60*60*1000;
                var currentTimeMinusOneHr = new Date().getTime() - onerHrInMs; // 60 minutes delay in data reporting
                console.log("lastPoll =",lastPoll,"\ncurrentTimeMinusOneHr =",currentTimeMinusOneHr,"\nDiff =", (lastPoll - currentTimeMinusOneHr)/onerHrInMs );
            if (  lastPoll < currentTimeMinusOneHr  ) raspberryAlive = ' Raspberry:<span class="dotRed"></span>'; // pi dead og python stopped?
                
            document.getElementById("IntroTop").innerHTML = dataBaseAlive + raspberryAlive;

        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert('Got an Error:',XMLHttpRequest);
            // console.log('Got an Error:\n',XMLHttpRequest,"\nStatus :",textStatus,"\nError thrown :",errorThrown );
        }

    });

}