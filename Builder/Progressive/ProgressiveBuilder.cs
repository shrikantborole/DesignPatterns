namespace Builder.Progressive
{
    public class Education
    {
        public string Name { get; set; }
        public bool IsElementary { get; set; }
        public string Description { get; set; }
    }
    public class Work
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime  StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsCurrent { get; set; }
        public string Company { get; set; }

    }
    public class Resume
    {
        public List<Education> Education { get; set; }
        public List<Work> WorkExperience { get; set; }

    }
    public class ResumeBuilder
    {
        private readonly Resume _resume = new Resume();

        public ResumeBuilder()
        {
            _resume.Education = new List<Education>();
            _resume.WorkExperience = new List<Work>();
        }

        public ElementarySchoolBuilder AddSchoolEducation()
        {
            return new ElementarySchoolBuilder(this, _resume);
        }
    }

    public class ElementarySchoolBuilder
    {
        private readonly Education _education = new Education();
        private readonly ResumeBuilder _resumeBuilder;
        private readonly Resume _resume;

        public ElementarySchoolBuilder(ResumeBuilder resumeBuilder, Resume resume)
        {
            _resumeBuilder = resumeBuilder;
            _resume = resume;
            _education.IsElementary = true;
        }

        public ElementarySchoolBuilder WithName(string name)
        {
            _education.Name = name;
            return this;
        }

        public ElementarySchoolBuilder WithDescription(string description)
        {
            _education.Description = description;
            return this;
        }

        public CollegeEducationBuilder AddCollegeEducation()
        {
            _resume.Education.Add(_education);
            return new CollegeEducationBuilder(_resumeBuilder, _resume);
        }
    }

    public class CollegeEducationBuilder
    {
        private readonly Education _education = new Education();
        private readonly ResumeBuilder _resumeBuilder;
        private readonly Resume _resume;

        public CollegeEducationBuilder(ResumeBuilder resumeBuilder, Resume resume)
        {
            _resumeBuilder = resumeBuilder;
            _resume = resume;
            _education.IsElementary = false;
        }

        public CollegeEducationBuilder WithName(string name)
        {
            _education.Name = name;
            return this;
        }

        public CollegeEducationBuilder WithDescription(string description)
        {
            _education.Description = description;
            return this;
        }

        public WorkExperienceBuilder AddWorkExperience()
        {
            _resume.Education.Add(_education);
            return new WorkExperienceBuilder(_resumeBuilder, _resume);
        }
    }

    public class WorkExperienceBuilder
    {
        private readonly Work _work = new Work();
        private readonly ResumeBuilder _resumeBuilder;
        private readonly Resume _resume;

        public WorkExperienceBuilder(ResumeBuilder resumeBuilder, Resume resume)
        {
            _resumeBuilder = resumeBuilder;
            _resume = resume;
        }

        public WorkExperienceBuilder WithTitle(string title)
        {
            _work.Title = title;
            return this;
        }

        public WorkExperienceBuilder WithDescription(string description)
        {
            _work.Description = description;
            return this;
        }

        public WorkExperienceBuilder WithCompany(string company)
        {
            _work.Company = company;
            return this;
        }

        public WorkExperienceBuilder WithStartDate(DateTime startDate)
        {
            _work.StartDate = startDate;
            return this;
        }

        public WorkExperienceBuilder WithEndDate(DateTime endDate)
        {
            _work.EndDate = endDate;
            return this;
        }

        public WorkExperienceBuilder IsCurrent(bool isCurrent)
        {
            _work.IsCurrent = isCurrent;
            return this;
        }

        public WorkExperienceBuilder AddWorkExperience()
        {
            _resume.WorkExperience.Add(_work);
            return new WorkExperienceBuilder(_resumeBuilder, _resume);
        }

        public Resume Build()
        {
            _resume.WorkExperience.Add(_work);
            return _resume;
        }
    }
   
    public class ProgressiveBuilder
    {
        public void CallProgressiveBuilder()
        {
            var initialBuilder = new ResumeBuilder();
            Resume resume = initialBuilder
                .AddSchoolEducation()
                    .WithName("My Elementary School")
                    .WithDescription("My Elementary School Description")
                .AddCollegeEducation()
                    .WithName("My College")
                    .WithDescription("My College Description")
                .AddWorkExperience()
                    .WithTitle("My Work Experience")
                    .WithDescription("My Work Experience Description")
                    .WithCompany("My Company")
                    .WithStartDate(new DateTime(2020, 3, 27))
                    .IsCurrent(true)
                .Build();
        }
    }
}
