
print "Введите размерность матрицы n "
n = gets.to_i

arr = Array.new(n.to_i){ rand(10) }

print "Исходный массив: "
p arr

ave = (1...(n.to_i - 1)).to_a.map{ |i| (arr[i - 1] + arr[i] + arr[i + 1])/3.0 }
ave.unshift((arr[0] + arr[1])/2.0)
ave.push((arr[-1] + arr[-2])/2.0)

ave.map!{ |elem| elem.round(3) }

puts "Новый массив#{ ave }"