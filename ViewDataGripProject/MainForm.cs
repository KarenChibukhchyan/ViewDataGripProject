using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ViewDataGripProject;

namespace ViewDataGripProject;

public partial class MainForm : Form
{
    private IPersonService _personService;
    private int _age = -1;
    private int _ID = -1;

    public int Age
    {
        get { return _age; }
        set
        {
            if (value > 0)
                _age = value;
            else
                _age = -1;
        }
    }

    public int ID
    {
        get { return _ID; }
        set
        {
            if (value > 0)
                _ID = value;
            else
                _ID = -1;
        }
    }

    public string PersonName { get; set; }


    public MainForm()
    {
        InitializeComponent();
        _personService = new PersonService();
        Populate(all: true);
    }

    private void Populate(bool all=false)
    {
        dataGridView1.Rows.Clear();
        IEnumerable<Person> list;
        if (all)
            list = _personService.GetAllPersons();
        else
            list = _personService.GetPersonsByCriteria(ID, PersonName, Age);

        foreach (var person in list)
        {
            dataGridView1.Rows.Add(person.ID, person.Name, person.Age);
        }
    }

    private void checkBoxID_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxID.Checked)
            textBoxID.Enabled = true;
        else
        {
            textBoxID.Enabled = false;
        }
        IdHandler();
        Populate();
    }

    private void checkBoxName_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxName.Checked)
            textBoxName.Enabled = true;
        else
        {
            textBoxName.Enabled = false;
        }
        NameHandler();
        Populate();

    }

    private void checkBoxAge_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxAge.Checked)
            textBoxAge.Enabled = true;
        else
        {
            textBoxAge.Enabled = false;
        }
        AgeHandler();
        Populate();
    }

    private void textBoxID_Leave(object sender, EventArgs e)
    {
        IdHandler();
        Populate();

    }

    private void textBoxName_Leave(object sender, EventArgs e)
    {
        NameHandler();
        Populate();

    }

    private void textBoxAge_Leave(object sender, EventArgs e)
    {
        AgeHandler();
        Populate();

    }

    private void NameHandler()
    {
        if (checkBoxName.Checked && !string.IsNullOrEmpty(textBoxName.Text))
        {
            PersonName = textBoxName.Text;
        }
        else
        {
            PersonName = "";
        }
    }

    private void AgeHandler()
    {
        if (checkBoxAge.Checked && !string.IsNullOrEmpty(textBoxAge.Text))
        {
            bool success = Int32.TryParse(textBoxAge.Text, out int number);
            if (success)
                Age = number;
        }
        else
        {
            Age = -1;
        }
    }

    private void IdHandler()
    {
        if (checkBoxID.Checked && !string.IsNullOrEmpty(textBoxID.Text))
        {
            bool success = Int32.TryParse(textBoxID.Text, out int number);
            if (success)
                ID = number;
        }
        else
        {
            ID = -1;
        }
    }

}
