namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Bidi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Bidi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.text.Bidi.staticClass, "toString", "()Ljava/lang/String;", ref global::java.text.Bidi._m0) as java.lang.String;
		}
		public new int Length
		{
			get
			{
				return getLength();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public int getLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.Bidi.staticClass, "getLength", "()I", ref global::java.text.Bidi._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public int getRunStart(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.Bidi.staticClass, "getRunStart", "(I)I", ref global::java.text.Bidi._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public int getRunLimit(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.Bidi.staticClass, "getRunLimit", "(I)I", ref global::java.text.Bidi._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public global::java.text.Bidi createLineBidi(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.text.Bidi>(this, global::java.text.Bidi.staticClass, "createLineBidi", "(II)Ljava/text/Bidi;", ref global::java.text.Bidi._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.text.Bidi;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public bool isMixed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.Bidi.staticClass, "isMixed", "()Z", ref global::java.text.Bidi._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public bool isLeftToRight()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.Bidi.staticClass, "isLeftToRight", "()Z", ref global::java.text.Bidi._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public bool isRightToLeft()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.Bidi.staticClass, "isRightToLeft", "()Z", ref global::java.text.Bidi._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public bool baseIsLeftToRight()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.Bidi.staticClass, "baseIsLeftToRight", "()Z", ref global::java.text.Bidi._m8);
		}
		public new int BaseLevel
		{
			get
			{
				return getBaseLevel();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public int getBaseLevel()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.Bidi.staticClass, "getBaseLevel", "()I", ref global::java.text.Bidi._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public int getLevelAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.Bidi.staticClass, "getLevelAt", "(I)I", ref global::java.text.Bidi._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int RunCount
		{
			get
			{
				return getRunCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public int getRunCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.Bidi.staticClass, "getRunCount", "()I", ref global::java.text.Bidi._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public int getRunLevel(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.Bidi.staticClass, "getRunLevel", "(I)I", ref global::java.text.Bidi._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static bool requiresBidi(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.Bidi._m13.native == global::System.IntPtr.Zero)
				global::java.text.Bidi._m13 = @__env.GetStaticMethodIDNoThrow(global::java.text.Bidi.staticClass, "requiresBidi", "([CII)Z");
			return @__env.CallStaticBooleanMethod(java.text.Bidi.staticClass, global::java.text.Bidi._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static void reorderVisually(byte[] arg0, int arg1, java.lang.Object[] arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.Bidi._m14.native == global::System.IntPtr.Zero)
				global::java.text.Bidi._m14 = @__env.GetStaticMethodIDNoThrow(global::java.text.Bidi.staticClass, "reorderVisually", "([BI[Ljava/lang/Object;II)V");
			@__env.CallStaticVoidMethod(java.text.Bidi.staticClass, global::java.text.Bidi._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public Bidi(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.Bidi._m15.native == global::System.IntPtr.Zero)
				global::java.text.Bidi._m15 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.Bidi.staticClass, global::java.text.Bidi._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public Bidi(java.text.AttributedCharacterIterator arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.Bidi._m16.native == global::System.IntPtr.Zero)
				global::java.text.Bidi._m16 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "<init>", "(Ljava/text/AttributedCharacterIterator;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.Bidi.staticClass, global::java.text.Bidi._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public Bidi(char[] arg0, int arg1, byte[] arg2, int arg3, int arg4, int arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.Bidi._m17.native == global::System.IntPtr.Zero)
				global::java.text.Bidi._m17 = @__env.GetMethodIDNoThrow(global::java.text.Bidi.staticClass, "<init>", "([CI[BIII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.Bidi.staticClass, global::java.text.Bidi._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		public static int DIRECTION_LEFT_TO_RIGHT
		{
			get
			{
				return 0;
			}
		}
		public static int DIRECTION_RIGHT_TO_LEFT
		{
			get
			{
				return 1;
			}
		}
		public static int DIRECTION_DEFAULT_LEFT_TO_RIGHT
		{
			get
			{
				return -2;
			}
		}
		public static int DIRECTION_DEFAULT_RIGHT_TO_LEFT
		{
			get
			{
				return -1;
			}
		}
		static Bidi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.Bidi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/Bidi"));
		}
	}
}
