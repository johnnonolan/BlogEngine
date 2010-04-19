using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cuke4Nuke.Framework;
using NUnit.Framework;

namespace BlogEngine.Tests
{
    public class ListOfPostSteps
    {
        int postCount = 0;

        [Given("^The blog has 0 posts")]
        public void BlogHasNPosts()
        {

        }

        [When("^When Navigating to the Home page")]
        public void PageIs()
        {

        }

        [Then("^Then Home page shows no posts.")]
        public void NoPosts()
        {
            Assert.AreEqual(0, posts.count);
        }
    }
}
