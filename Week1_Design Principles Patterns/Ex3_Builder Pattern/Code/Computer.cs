using System;

namespace BuilderPatternExample
{
    public class Computer
    {
        public string? CPU { get; } = string.Empty;
        public string? RAM { get; } = string.Empty;
        public string? Storage { get; } = string.Empty;

        private Computer(Builder builder)
        {
            CPU = builder.CPU;
            RAM = builder.RAM;
            Storage = builder.Storage;
        }

        public string String()
        {
            return $"CPU={CPU}\nRAM={RAM}\nStorage={Storage}\n";
        }

        public class Builder
        {
            public string? CPU { get; private set; }
            public string? RAM { get; private set; }
            public string? Storage { get; private set; }

            public Builder buildCPU(string cpu)
            {
                CPU = cpu;
                return this;
            }

            public Builder buildRAM(string ram)
            {
                RAM = ram;
                return this;
            }

            public Builder buildStorage(string storage)
            {
                Storage = storage;
                return this;
            }

            public Computer Build()
            {
                return new Computer(this);
            }
        }
    }
}