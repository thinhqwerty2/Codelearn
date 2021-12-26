function includeJS(incFile) {
    document.write('<script type="text/javascript" src="' + incFile + '"></script>');
}
var number = 1;
var string = "1";
var array = [1];
var object = {
    key: "value",
}

function stringInString(a, b) {
    console.log(b.includes(a));
    if (b.indexOf(a) && typeof a == "string" && typeof b == "string") {
        return true;
    } else {
        return false;
    }
}

function getDifferentSeconds(date1, date2) {
    var x = new Date(date1);
    var y = new Date(date2);
    return x.getTime() - y.getTime();
}

function isIPv4Address(inputString) {
    var word = inputString.split(".");
    if (word.length == 4) {
        for (var item of word) {
            if (typeof item != "number" || item > 255 || item < 0) {
                return false;
            }
        }
        return true;
    } else {
        return false;
    }
}

function primaryFactor347(n) {
    var temp = n;
    while (true) {

        if (temp % 7 == 0) {
            temp = temp / 7;
        } else if (temp % 4 == 0) {
            temp = temp / 4;
        } else if (temp % 3 == 0) {
            temp = temp / 3;
        } else {
            break;
        }
    }
    if (temp == 1 && n != 1) {
        return true;
    } else {
        return false;
    }
}

//Phan tich n thanh thua so nguyen to tra ve 1 object co thuoc tinh number la so nguyen to
//va thuoc tinh exponent la so mu tuong ung
function fact(n) {
    var rs = {
        number: [],
        exponent: [],
    };
    var temp = 2;
    while (n != 1) {
        if (n % temp == 0) {
            n = n / temp;
            if (rs.number[rs.number.length - 1] != temp) {
                rs.number.push(temp);
                rs.exponent.push(1);
            } else {
                rs.exponent[rs.number.length - 1]++;
            }
        } else {
            temp += 1;
        }
    }
    return rs;

}
// Tim uoc nguyen duong cua so nguyen duong n
//Cho den so nguyen duong to
function divisor(n, to) {
    var rs = [];
    for (let i = 2; i <= to; i++) {
        const element = n[i];
        if (n % i == 0) {
            rs.push(i);
        }

    }
    return rs

}


/*
  Cho số tự nhiên product
Hãy tìm số nguyên dương nhỏ nhất (lớn hơn 0) mà tích các chữ số của số đó bằng product.
 Nếu không có số thỏa mãn, trả ra -1.
 */
function digitsProduct(product) {
    var rs = "";
    switch (product) {
        case 0:
            return 10;
        case 1:
            return 1;

        default:
            for (const iterator = 9; iterator > 1; iterator--) {
                while (product % iterator == 0) {
                    rs = iterator + rs;
                    product = product / iterator;
                }
            }
            if (rs == "") {
                return -1;
            } else {

                return parseInt(rs);
            }
    }
}
/**
 * You are given an array of desired filenames in the order of their creation.
 *  Since two files cannot have equal names,the one which comes 
 * later will have an addition to its name in a form of (k),
 *  where k is the smallest positive integer such that the 
 * obtained name is not used yet.
 *Return an array of names that will be given to the files.
 * 
 */
function fileNaming(names) {
    var rs = [];
    for (const iterator of names) {
        var k = 1;
        var index = rs.indexOf(iterator);
        if (index != -1) {
            while (rs.includes(rs[index].concat("(", k, ")"))) {
                k++;
            }
            rs.push(rs[index].concat("(", k, ")"));
        } else {
            rs.push(iterator);
        }
    }
    return rs;
}

function gift(n, k) {
    var arr = new Array(n).fill(0);
    var rs = new Array(n).fill(0);

    for (const iterator of k) {
        arr[iterator[0] - 1] += iterator[2];
        if (iterator[1] == n) continue;
        arr[iterator[1]] -= iterator[2];

    }
    for (let i = 1; i < rs.length; i++) {
        arr[i] = arr[i - 1] + arr[i];
    }
    return arr;
}

/**
 * Bạn được cho 1 vector T gồm các số,
 *  với mỗi số Ti bạn hãy đếm số lượng bit 1 
 * khi được viết dưới dạng nhị phân của các số từ 1 tới Ti .
 */

function countBit(T) {
    T = T.sort();
    var arr = new Array(T[T.length - 1]).fill(0);
    for (let i = 1; i < arr.length; i++) {
        const value = arr[i];
        if (value = value >> 1) {
            arr[i] = arr[i] + 1;
        }
    }

    for (const iterator of T) {

    }
}
//console.log([468107, 830757, 230911, 273459, 974295, 218789, 646738, 235651, 290844, 726751].sort())

/**
 * Tong bit 1 tu 0 den x la x=2^n -1 
 */
function sumBitOne(x) {
    return Math.log2(x + 1) * (x + 1) / 2;
}

/**
 * Một số được gọi là composite number khi nó không phải là số nguyên tố 
 * và là số nguyên dương lớn hơn 1(ví dụ 4, 6, 8, 9, ...).
 *  Cho một số nguyên dương n, hãy tính số lượng số composite 
 * number để tạo thành số n nhiều nhất có thể.
 *  Nếu không thể tạo ra được n, hãy trả về -1.
 */
function maxComNumbers(n) {

    switch (n) {
        case 3:
        case 7:
        case 11:
        case 5:
            return -1;
        case 6:
        case 4:
        case 9:
            return 1;
        default:
            break;
    }

    if (n % 4 == 0) {
        return n / 4
    } else {
        return Number.parseInt(n / 4) - 1;
    }
}
/**
 * Bạn là người quản lý nhóm cứu hộ nổi tiếng: Hội kỵ mã. Bạn phải chọn 1 thành viên trong đội đi làm nhiệm vụ giải cứu trên 1 mặt phẳng 2 chiều.

Các kỵ mã trong đội của bạn di chuyển hình chân mã độ dài n. Ví dụ, nếu 1 kỵ mã có n = 2, anh ta sẽ di chuyển như quân mã trên bàn cờ vua.
 Nếu n = 3, anh ta có thể đi từ điểm (0, 0) đến 1 trong 8 điểm sau:

(3, 1) (3, -1), ( -3, 1), (-3, -1), (1, 3), (1, -3), (-1, 3) hoặc (-1, -3).

Bạn biết độ dài n của tất cả các thành viên, và tọa độ (x, y) của 1 người bị nạn cần cứu hộ. Trụ sở của nhóm nằm ở điểm (0, 0).
 Hãy kiểm tra xem có thành viên nào có thể tới được điểm (x, y) để cứu người bị nạn hay không.
N la mang chua do dai n cua tat ca cac thanh vien
x,y la toa do nguoi can cuu

 */

function canRescue(N, x, y) {
    for (const item of N) {
        if (item % 2 == 0) {
            return true;
        }
    }
    if (x % 2 == y % 2) {
        return true;
    } else {
        return false;
    }
}


/**
 * Cho n số nguyên không âm a1, a2, ..., an , trong đó mỗi số biểu diễn một điểm tại toạ độ(i, ai).
 *  n đường thẳng đứng được vẽ sao cho 2 điểm của của đường thẳng i nằm tại (i, ai) và (i, 0). 
 * Tìm 2 đường thẳng cùng với trục x tạo thành 1 thùng chưa, sao cho thùng chứa được nhiều nước nhất.

Lưu ý: bạn không được nghiêng thùng chưa và n phải ít nhất là 2.
 */
function maxArea(heights) {
    var right = heights.length - 1;
    var left = 0;
    var rs = 0;
    while (left < right) {
        var newArea = Math.min(heights[left], heights[right]) * (right - left);
        rs = Math.max(rs, newArea);

        if (heights[left] > heights[right]) {
            right--;
        } else {
            left++;
        }
    }
    return rs;
}

console.log("ABC");