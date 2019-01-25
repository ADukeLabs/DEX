class CityButton extends React.Component {

    constructor(props)
    {
        super(props);
        this.state = { isButtonOn: false };
        this.handleClick = this.handleClick.bind(this);
    }

    handleClick(e) {
        e.preventDefault(e);
        this.setState({ isButtonOn: !this.state.isButtonOn });
        console.log(this.state.isButtonOn);
    }
    render() {
        return (
            <div className="city-div">
                <button className='city-button btn btn-primary btn-block' type="button" onClick={this.handleClick}>Wellington, New Zealand</button>
                <CompanyList />
            </div>
        );
    }          
}

class CompanyList extends React.Component() {

    render() {
        if (this.props.state.isButtonOn == true) {
            return (
                data.map((c) =>
                    <div className="col-xs-10 col-xs-offset-2 col-sm-6 col-sm-offset-4">
                        <button type="button" className="btn btn-primary">c.Name</button>
                    </div>
                )
            );
        }
        
    }
}


class Menu extends React.Component {
    render() {
        return (
            <CityButton />
        );
    }
}


class App extends React.Component {
    render() {
        return (
            <div>
                <Menu />
            </div>    
        );
    }
}

ReactDOM.render(
    <App/>,
    document.getElementById("app")
);