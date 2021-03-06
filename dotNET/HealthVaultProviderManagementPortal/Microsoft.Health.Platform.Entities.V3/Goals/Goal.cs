﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// MIT License
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the ""Software""), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

namespace Microsoft.Health.Platform.Entities.V3.Goals
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Health.Platform.Entities.V3.Enums;

    /// <summary>
    /// A goal defines a target for a measurement or action to be performed by a user.
    /// For example, walk 5000 steps per day, burn 1500 calories per day
    /// </summary>
    public class Goal
    {
        /// <summary>
        /// The unique identifier of a goal instance.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The name of the goal.
        /// For example, Daily walk goal
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The description of the goal.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The start date of the goal in Universal Time Zone(UTC).
        /// </summary>
        public DateTimeOffset? StartDate { get; set; }

        /// <summary>
        /// The end date of the goal in Universal Time Zone(UTC).
        /// If the end date is in the future, this is the target date.
        /// </summary>
        public DateTimeOffset? EndDate { get; set; }

        /// <summary>
        /// Specifies the type of data related to this goal.
        /// </summary>
        public GoalType GoalType { get; set; }

        /// <summary>
        /// The goal recurrence metrics.
        /// For example, A goal can be defined on a weekly interval, meaning the target is intended to be achieved every week. Walking 50000 steps in a week.
        /// </summary>
        public GoalRecurrenceMetrics RecurrenceMetrics { get; set; }

        /// <summary>
        /// The primary range of achievement for the goal.
        /// For example, the ideal weight or daily steps target.
        /// </summary>
        public GoalRange Range { get; set; }

        /// <summary>
        /// Other ranges of achievement for the goal.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Justification = "Set needed for serialization.")]
        public IList<GoalRange> AdditionalRanges { get; set; }
    }
}