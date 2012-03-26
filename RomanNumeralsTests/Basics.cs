using NUnit.Framework;
using RomanNumerals;
using Shouldly;

namespace RomanNumeralsTests
{
    [TestFixture]
    public class Basics
    {
        [Test]
        public void Zero_should_return_nothing()
        {
            0.ToRoman().ShouldBe("");
        }

        [Test]
        public void One_should_return_I()
        {
            1.ToRoman().ShouldBe("I");
        }

        [Test]
        public void Two_should_return_II()
        {
            2.ToRoman().ShouldBe("II");
        }

        [Test]
        public void Three_should_return_III()
        {
            3.ToRoman().ShouldBe("III");
        }

        [Test]
        public void Four_should_return_IV()
        {
            4.ToRoman().ShouldBe("IV");
        }

        [Test]
        public void Nine_should_return_IX()
        {
            9.ToRoman().ShouldBe("IX");
        }

        [Test]
        public void FortyNine_should_return_XLIX()
        {
            49.ToRoman().ShouldBe("XLIX");
        }

        [Test]
        public void NinetyNine_should_return_XCIX()
        {
            99.ToRoman().ShouldBe("XCIX");
        }
    }
}