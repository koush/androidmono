namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Arrays : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Arrays(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static bool equals(java.lang.Object[] arg0, java.lang.Object[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m0.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m0 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([Ljava/lang/Object;[Ljava/lang/Object;)Z");
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static bool equals(float[] arg0, float[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m1.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m1 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([F[F)Z");
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static bool equals(double[] arg0, double[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m2.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m2 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([D[D)Z");
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static bool equals(bool[] arg0, bool[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m3.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m3 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([Z[Z)Z");
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static bool equals(byte[] arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m4.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m4 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([B[B)Z");
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static bool equals(char[] arg0, char[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m5.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m5 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([C[C)Z");
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static bool equals(short[] arg0, short[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m6.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m6 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([S[S)Z");
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static bool equals(int[] arg0, int[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m7.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m7 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([I[I)Z");
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static bool equals(long[] arg0, long[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m8.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m8 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "equals", "([J[J)Z");
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static global::java.lang.String toString(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m9.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m9 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([Ljava/lang/Object;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static global::java.lang.String toString(int[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m10.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m10 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static global::java.lang.String toString(short[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m11.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m11 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([S)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static global::java.lang.String toString(char[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m12.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m12 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([C)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static global::java.lang.String toString(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m13.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m13 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([B)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static global::java.lang.String toString(bool[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m14.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m14 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([Z)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static global::java.lang.String toString(float[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m15.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m15 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([F)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static global::java.lang.String toString(double[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m16.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m16 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([D)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public static global::java.lang.String toString(long[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m17.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m17 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "toString", "([J)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static int hashCode(float[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m18.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m18 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([F)I");
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static int hashCode(long[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m19.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m19 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([J)I");
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public static int hashCode(int[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m20.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m20 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([I)I");
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public static int hashCode(short[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m21.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m21 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([S)I");
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public static int hashCode(char[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m22.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m22 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([C)I");
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public static int hashCode(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m23.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m23 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([B)I");
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public static int hashCode(bool[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m24.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m24 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([Z)I");
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public static int hashCode(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m25.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m25 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([Ljava/lang/Object;)I");
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public static int hashCode(double[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m26.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m26 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "hashCode", "([D)I");
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public static int[] copyOf(int[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m27.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m27 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([II)[I");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as int[];
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public static global::java.lang.Object[] copyOf(java.lang.Object[] arg0, int arg1, java.lang.Class arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m28.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m28 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([Ljava/lang/Object;ILjava/lang/Class;)[Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public static float[] copyOf(float[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m29.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m29 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([FI)[F");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as float[];
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public static double[] copyOf(double[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m30.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m30 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([DI)[D");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<double>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as double[];
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public static bool[] copyOf(bool[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m31.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m31 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([ZI)[Z");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as bool[];
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public static char[] copyOf(char[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m32.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m32 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([CI)[C");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as char[];
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public static long[] copyOf(long[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m33.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m33 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([JI)[J");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as long[];
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public static global::java.lang.Object[] copyOf(java.lang.Object[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m34.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m34 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([Ljava/lang/Object;I)[Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public static byte[] copyOf(byte[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m35.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m35 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([BI)[B");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public static short[] copyOf(short[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m36.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m36 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOf", "([SI)[S");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<short>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as short[];
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public static char[] copyOfRange(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m37.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m37 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([CII)[C");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as char[];
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public static bool[] copyOfRange(bool[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m38.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m38 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([ZII)[Z");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as bool[];
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public static double[] copyOfRange(double[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m39.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m39 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([DII)[D");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<double>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as double[];
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public static float[] copyOfRange(float[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m40.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m40 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([FII)[F");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as float[];
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public static long[] copyOfRange(long[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m41.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m41 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([JII)[J");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as long[];
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public static int[] copyOfRange(int[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m42.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m42 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([III)[I");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as int[];
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public static short[] copyOfRange(short[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m43.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m43 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([SII)[S");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<short>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as short[];
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public static byte[] copyOfRange(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m44.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m44 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([BII)[B");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public static global::java.lang.Object[] copyOfRange(java.lang.Object[] arg0, int arg1, int arg2, java.lang.Class arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m45.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m45 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([Ljava/lang/Object;IILjava/lang/Class;)[Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public static global::java.lang.Object[] copyOfRange(java.lang.Object[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m46.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m46 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "copyOfRange", "([Ljava/lang/Object;II)[Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public static void fill(double[] arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m47.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m47 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([DD)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public static void fill(float[] arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m48.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m48 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([FF)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public static void fill(float[] arg0, int arg1, int arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m49.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m49 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([FIIF)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public static void fill(bool[] arg0, int arg1, int arg2, bool arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m50.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m50 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([ZIIZ)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public static void fill(byte[] arg0, int arg1, int arg2, byte arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m51.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m51 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([BIIB)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public static void fill(byte[] arg0, byte arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m52.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m52 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([BB)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m53;
		public static void fill(char[] arg0, int arg1, int arg2, char arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m53.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m53 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([CIIC)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m54;
		public static void fill(short[] arg0, short arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m54.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m54 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([SS)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m55;
		public static void fill(java.lang.Object[] arg0, int arg1, int arg2, java.lang.Object arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m55.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m55 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([Ljava/lang/Object;IILjava/lang/Object;)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m55, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m56;
		public static void fill(java.lang.Object[] arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m56.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m56 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([Ljava/lang/Object;Ljava/lang/Object;)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m56, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m57;
		public static void fill(char[] arg0, char arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m57.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m57 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([CC)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m57, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m58;
		public static void fill(short[] arg0, int arg1, int arg2, short arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m58.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m58 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([SIIS)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m58, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m59;
		public static void fill(long[] arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m59.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m59 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([JJ)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m59, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m60;
		public static void fill(long[] arg0, int arg1, int arg2, long arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m60.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m60 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([JIIJ)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m60, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m61;
		public static void fill(int[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m61.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m61 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([II)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m61, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m62;
		public static void fill(int[] arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m62.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m62 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([IIII)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m62, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m63;
		public static void fill(bool[] arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m63.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m63 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([ZZ)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m63, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m64;
		public static void fill(double[] arg0, int arg1, int arg2, double arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m64.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m64 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "fill", "([DIID)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m64, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m65;
		public static void sort(int[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m65.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m65 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([I)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m65, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m66;
		public static void sort(java.lang.Object[] arg0, java.util.Comparator arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m66.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m66 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([Ljava/lang/Object;Ljava/util/Comparator;)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m66, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m67;
		public static void sort(java.lang.Object[] arg0, int arg1, int arg2, java.util.Comparator arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m67.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m67 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([Ljava/lang/Object;IILjava/util/Comparator;)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m67, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m68;
		public static void sort(long[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m68.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m68 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([JII)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m68, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m69;
		public static void sort(long[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m69.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m69 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([J)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m69, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m70;
		public static void sort(float[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m70.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m70 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([FII)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m70, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m71;
		public static void sort(float[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m71.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m71 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([F)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m71, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m72;
		public static void sort(double[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m72.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m72 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([DII)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m72, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m73;
		public static void sort(double[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m73.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m73 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([D)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m73, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m74;
		public static void sort(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m74.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m74 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([BII)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m74, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m75;
		public static void sort(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m75.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m75 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([B)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m75, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m76;
		public static void sort(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m76.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m76 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([CII)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m76, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m77;
		public static void sort(short[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m77.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m77 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([S)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m77, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m78;
		public static void sort(short[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m78.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m78 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([SII)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m78, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m79;
		public static void sort(int[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m79.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m79 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([III)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m79, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m80;
		public static void sort(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m80.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m80 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([Ljava/lang/Object;)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m80, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m81;
		public static void sort(java.lang.Object[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m81.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m81 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([Ljava/lang/Object;II)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m81, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m82;
		public static void sort(char[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m82.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m82 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "sort", "([C)V");
			@__env.CallStaticVoidMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m82, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m83;
		public static int binarySearch(char[] arg0, char arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m83.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m83 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([CC)I");
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m83, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m84;
		public static int binarySearch(java.lang.Object[] arg0, java.lang.Object arg1, java.util.Comparator arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m84.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m84 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Comparator;)I");
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m84, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m85;
		public static int binarySearch(short[] arg0, int arg1, int arg2, short arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m85.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m85 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([SIIS)I");
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m85, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m86;
		public static int binarySearch(short[] arg0, short arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m86.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m86 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([SS)I");
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m86, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m87;
		public static int binarySearch(float[] arg0, int arg1, int arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m87.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m87 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([FIIF)I");
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m87, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m88;
		public static int binarySearch(int[] arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m88.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m88 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([IIII)I");
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m88, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m89;
		public static int binarySearch(int[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m89.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m89 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([II)I");
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m89, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m90;
		public static int binarySearch(float[] arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m90.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m90 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([FF)I");
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m90, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m91;
		public static int binarySearch(long[] arg0, int arg1, int arg2, long arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m91.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m91 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([JIIJ)I");
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m91, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m92;
		public static int binarySearch(double[] arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m92.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m92 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([DD)I");
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m92, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m93;
		public static int binarySearch(long[] arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m93.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m93 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([JJ)I");
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m93, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m94;
		public static int binarySearch(java.lang.Object[] arg0, int arg1, int arg2, java.lang.Object arg3, java.util.Comparator arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m94.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m94 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([Ljava/lang/Object;IILjava/lang/Object;Ljava/util/Comparator;)I");
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m94, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m95;
		public static int binarySearch(double[] arg0, int arg1, int arg2, double arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m95.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m95 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([DIID)I");
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m95, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m96;
		public static int binarySearch(java.lang.Object[] arg0, int arg1, int arg2, java.lang.Object arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m96.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m96 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([Ljava/lang/Object;IILjava/lang/Object;)I");
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m96, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m97;
		public static int binarySearch(byte[] arg0, byte arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m97.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m97 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([BB)I");
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m97, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m98;
		public static int binarySearch(byte[] arg0, int arg1, int arg2, byte arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m98.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m98 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([BIIB)I");
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m98, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m99;
		public static int binarySearch(java.lang.Object[] arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m99.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m99 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([Ljava/lang/Object;Ljava/lang/Object;)I");
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m99, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m100;
		public static int binarySearch(char[] arg0, int arg1, int arg2, char arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m100.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m100 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "binarySearch", "([CIIC)I");
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m101;
		public static global::java.util.List asList(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m101.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m101 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "asList", "([Ljava/lang/Object;)Ljava/util/List;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m102;
		public static int deepHashCode(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m102.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m102 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "deepHashCode", "([Ljava/lang/Object;)I");
			return @__env.CallStaticIntMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m103;
		public static bool deepEquals(java.lang.Object[] arg0, java.lang.Object[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m103.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m103 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "deepEquals", "([Ljava/lang/Object;[Ljava/lang/Object;)Z");
			return @__env.CallStaticBooleanMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m104;
		public static global::java.lang.String deepToString(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Arrays._m104.native == global::System.IntPtr.Zero)
				global::java.util.Arrays._m104 = @__env.GetStaticMethodIDNoThrow(global::java.util.Arrays.staticClass, "deepToString", "([Ljava/lang/Object;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.util.Arrays.staticClass, global::java.util.Arrays._m104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		static Arrays()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Arrays.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Arrays"));
		}
	}
}
