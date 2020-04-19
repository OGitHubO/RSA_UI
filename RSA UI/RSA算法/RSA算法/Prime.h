#ifndef __PRIME_H__
#define __PRIME_H__

#include "BigInt.h"

/*****************************************************************
RSA related operations
Rab, Rabin Miller algorithm for prime test
Euc, Euclidean algorithm to solve congruence equation
RsaTrans, iterative square algorithm for power modulus operation
GetPrime, generate random large prime numbers of specified length
*****************************************************************/
int RabPrimeTest(const CBigInt& prime);
//CBigInt Euc(CBigInt& A);
CBigInt RsaTrans(const CBigInt& N, const CBigInt& A, const CBigInt& B);
CBigInt GetBigIntPrime(int bits);

CBigInt ExtEuclid(const CBigInt& a, const CBigInt& b, CBigInt& x, CBigInt& y);
CBigInt CongruenceEquation(const CBigInt& a, const CBigInt& n);
__int64 CongruenceEquation64(__int64 a, __int64 n);
CBigInt ModularPower(const CBigInt& M, const CBigInt& E, const CBigInt& N);
CBigInt MontgomeryModularPower(const CBigInt& M, const CBigInt& E, const CBigInt& N);
bool MillerRabin(const CBigInt& n);
bool IsPrimeNumber(const CBigInt& n);
CBigInt GeneratePrime(int bits);


#endif //__PRIME_H__