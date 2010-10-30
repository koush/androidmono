namespace junit.framework
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Assert : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Assert(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static void assertTrue(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m0.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m0 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertTrue", "(Ljava/lang/String;Z)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static void assertTrue(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m1.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m1 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertTrue", "(Z)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static void assertFalse(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m2.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m2 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertFalse", "(Z)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static void assertFalse(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m3.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m3 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertFalse", "(Ljava/lang/String;Z)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static void fail(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m4.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m4 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "fail", "(Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static void fail()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m5.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m5 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "fail", "()V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static void assertEquals(java.lang.String arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m6.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m6 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;FFF)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static void assertEquals(float arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m7.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m7 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(FFF)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static void assertEquals(java.lang.String arg0, long arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m8.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m8 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;JJ)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static void assertEquals(long arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m9.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m9 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(JJ)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static void assertEquals(bool arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m10.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m10 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(ZZ)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static void assertEquals(java.lang.String arg0, byte arg1, byte arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m11.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m11 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;BB)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static void assertEquals(byte arg0, byte arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m12.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m12 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(BB)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static void assertEquals(java.lang.String arg0, char arg1, char arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m13.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m13 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;CC)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static void assertEquals(char arg0, char arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m14.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m14 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(CC)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static void assertEquals(java.lang.String arg0, short arg1, short arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m15.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m15 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;SS)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static void assertEquals(short arg0, short arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m16.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m16 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(SS)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public static void assertEquals(java.lang.String arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m17.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m17 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;II)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static void assertEquals(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m18.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m18 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(II)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static void assertEquals(java.lang.String arg0, bool arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m19.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m19 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;ZZ)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public static void assertEquals(java.lang.String arg0, java.lang.Object arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m20.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m20 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public static void assertEquals(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m21.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m21 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public static void assertEquals(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m22.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m22 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public static void assertEquals(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m23.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m23 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public static void assertEquals(java.lang.String arg0, double arg1, double arg2, double arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m24.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m24 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(Ljava/lang/String;DDD)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public static void assertEquals(double arg0, double arg1, double arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m25.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m25 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertEquals", "(DDD)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public static void assertNotNull(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m26.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m26 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertNotNull", "(Ljava/lang/Object;)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public static void assertNotNull(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m27.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m27 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertNotNull", "(Ljava/lang/String;Ljava/lang/Object;)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public static void assertNull(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m28.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m28 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertNull", "(Ljava/lang/Object;)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public static void assertNull(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m29.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m29 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertNull", "(Ljava/lang/String;Ljava/lang/Object;)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public static void assertSame(java.lang.String arg0, java.lang.Object arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m30.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m30 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertSame", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public static void assertSame(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m31.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m31 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertSame", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public static void assertNotSame(java.lang.String arg0, java.lang.Object arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m32.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m32 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertNotSame", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public static void assertNotSame(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m33.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m33 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.Assert.staticClass, "assertNotSame", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			@__env.CallStaticVoidMethod(junit.framework.Assert.staticClass, global::junit.framework.Assert._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		protected Assert() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.Assert._m34.native == global::System.IntPtr.Zero)
				global::junit.framework.Assert._m34 = @__env.GetMethodIDNoThrow(global::junit.framework.Assert.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.Assert.staticClass, global::junit.framework.Assert._m34);
			Init(@__env, handle);
		}
		static Assert()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.framework.Assert.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/framework/Assert"));
		}
		internal static void InitJNI()
		{
		}
	}
}
