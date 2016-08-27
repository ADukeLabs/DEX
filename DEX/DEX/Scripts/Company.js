function Company(data) {
    this.Id = JSON.parse(data.Id);
    this.Name = data.Name;
    this.Address = data.Address;
    this.Industry = data.Industry;
    this.City = data.City;
    this.contacts = data.Contacts;
}