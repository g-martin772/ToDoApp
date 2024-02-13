using System.Windows.Input;
using FontAwesome.Sharp;

namespace Portfolio.ViewModels;

public class MainViewModel : ViewModelBase
{
    private ViewModelBase m_CurrentChildView;
    private string m_Caption;
    private IconChar m_Icon;

    public ViewModelBase CurrentChildView
    {
        get => m_CurrentChildView;
        set { m_CurrentChildView = value; OnPropertyChanged("CurrentChildView"); }
    }

    public string Caption
    {
        get { return m_Caption; }
        set { m_Caption = value;  OnPropertyChanged("Caption"); }
    }

    public IconChar Icon
    {
        get => m_Icon;
        set { m_Icon = value;  OnPropertyChanged(nameof(Icon)); }
    }

    public ICommand ShowHomeViewCommand { get; }
    public ICommand ShowMyEducationViewCommand { get; }
    public ICommand ShowMyProjectsViewCommand { get; }
    public ICommand ShowMySkillsViewCommand { get; }

    public MainViewModel()
    {
        ShowHomeViewCommand = new ViewModelCommand(ExecuteShowHomeViewCommand);
        ShowMyEducationViewCommand = new ViewModelCommand(ExecuteShowMyEducationViewCommand);
        ShowMyProjectsViewCommand = new ViewModelCommand(ExecuteShowMyProjectsViewCommand);
        ShowMySkillsViewCommand = new ViewModelCommand(ExecuteShowMySkillsViewCommand);

        ExecuteShowHomeViewCommand(null!);
    }

    private void ExecuteShowMySkillsViewCommand(object obj)
    {
        //CurrentChildView = new MySkillsViewModel();
        Caption = "My Skills";
        Icon = IconChar.Tools;
    }

    private void ExecuteShowMyProjectsViewCommand(object obj)
    {
        //CurrentChildView = new MyProjectsViewModel();
        Caption = "My Projects";
        Icon = IconChar.ProjectDiagram;
    }

    private void ExecuteShowMyEducationViewCommand(object obj)
    {
        //CurrentChildView = new MyEducationViewModel();
        Caption = "My Education";
        Icon = IconChar.SchoolFlag;
    }

    private void ExecuteShowHomeViewCommand(object obj)
    {
        //CurrentChildView = new HomeViewModel();
        Caption = "Home";
        Icon = IconChar.Home;
    }
}