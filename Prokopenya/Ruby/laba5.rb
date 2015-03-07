require 'matrix'
mas = []
puts "Введите n:"
lines = gets.chomp.to_i

(0...lines).each do |l|
  mas[l] = []
  (0...lines).each do |c|
    mas[l][c] = rand(100)-rand(100)
  end
  print mas[l]
  puts ""
 end

p Matrix[*mas].det


