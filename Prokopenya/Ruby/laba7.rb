mas = []
puts "Введите n:"
lines = gets.chomp.to_i

puts "Введите m:"
columns = gets.chomp.to_i

(0...lines).each do |l|
  mas[l] = []
  (0...columns).each do |c|
    print "[#{l+1}, #{c+1}] = "
    mas[l][c] = rand(100)
    puts a[l][c]
  end
end

puts mas.map{ |arr| arr.max }.min
