# Creating-a-Waterfall-Chart-to-track-monthly-Sales

## Waterfall Chart

[WaterfallSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.WaterfallSeries.html) clarifies the cumulative effect of a set of provided positive and negative values. The series is represented by a rectangle and a connector between the rectangles. To render a waterfall chart, create an instance of [WaterfallSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.WaterfallSeries.html), and add it to the [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) collection property of the [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html?tabs=tabid-1)

* [SummaryBindingPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.WaterfallSeries.html#Syncfusion_Maui_Charts_WaterfallSeries_SummaryBindingPath) of the string type is used to get or set the path value on the source subject to serve summary values to the series.
* [SummaryPointsBrush](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.WaterfallSeries.html#Syncfusion_Maui_Charts_WaterfallSeries_SummaryPointsBrush) of brush type is used to change the fill of the summary segment of the series. .
* [NegativePointsBrush](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.WaterfallSeries.html#Syncfusion_Maui_Charts_WaterfallSeries_NegativePointsBrush) of brush type is used to change the fill of the negative segment of the series.
* [AllowAutoSum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.WaterfallSeries.html#Syncfusion_Maui_Charts_WaterfallSeries_AllowAutoSum) of bool type is used to change the summary segment calculation. By default, the property is true. When disabling this property, it renders the segment by using the y value of provided ItemsSource collection.
* [ShowConnectorLine](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.WaterfallSeries.html#Syncfusion_Maui_Charts_WaterfallSeries_ShowConnectorLine) of bool type is used to enable or disable the connector line. By default, the property value is true.

**Connector line customization :** The connector line can be customized by applying the [ConnectorLineStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.WaterfallSeries.html#Syncfusion_Maui_Charts_WaterfallSeries_ConnectorLineStyle) property of the series.


The Waterfall chart type is used to visualize the progression or flow of a process or project over time. This sample demonstrates how to create a Waterfall Chart that tracks monthly Sales in .NET 
MAUI (SfCartesianChart)

<img width="701" alt="WaterfallChartImage" src="https://user-images.githubusercontent.com/105496706/236203929-ded8fc3d-692a-454a-923a-6085a5cdacdf.png">

### Customizing the chart appearance
In this example, we have enhanced the appearance of our waterfall chart by customizing various elements, such as the appearance of axis elements, series, and titles.

#### Axis Customization
We can customize axis elements, including axis label style, major tickline style, and disabling the visibility of axis and axis major gridlines.

#### Series Customization
We can customize the series segment colors based on functionality using the [NegativePointsBrush](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.WaterfallSeries.html#Syncfusion_Maui_Charts_WaterfallSeries_NegativePointsBrush) and [SummaryPointsBrush](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.WaterfallSeries.html#Syncfusion_Maui_Charts_WaterfallSeries_SummaryPointsBrush) properties. NegativePointsBrush fills the negative segments, while SummaryPointsBrush fills the summary segments. Further customization includes adding connector lines with their associated styles and integrating data labels with their respective styling properties onto the chart.

#### Adding a Chart Title
A chart title provides essential context to the plotted data.

For a detailed explanation, refer to the [monthly sales tracking blog](https://www.syncfusion.com/blogs/post/dotnet-maui-waterfall-chart-track-monthly-sales.aspx)
