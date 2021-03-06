using App.Metrics.DotNetRuntime.EventSources;
using App.Metrics.DotNetRuntime.StatsCollectors.Util;
using NUnit.Framework;

namespace AppMetrics.DotNetRuntime.Tests.StatsCollectors.Util
{
    [TestFixture]
    public class LabelGeneratorTests
    {
        [Test]
        public void MapEnumToLabelValues_will_generate_labels_with_snake_cased_names()
        {
            var labels = LabelGenerator.MapEnumToLabelValues<DotNetRuntimeEventSource.GCReason>();
            
            Assert.That(labels[DotNetRuntimeEventSource.GCReason.AllocLarge], Is.EqualTo("alloc_large"));
            Assert.That(labels[DotNetRuntimeEventSource.GCReason.OutOfSpaceLOH], Is.EqualTo("out_of_space_loh"));
        }
    }
}