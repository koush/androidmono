namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class StringCharacterIterator : java.lang.Object, CharacterIterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal StringCharacterIterator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.StringCharacterIterator.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.text.StringCharacterIterator._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.StringCharacterIterator.staticClass, "hashCode", "()I", ref global::java.text.StringCharacterIterator._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.StringCharacterIterator.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.text.StringCharacterIterator._m2) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public char next()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.StringCharacterIterator.staticClass, "next", "()C", ref global::java.text.StringCharacterIterator._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public char previous()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.StringCharacterIterator.staticClass, "previous", "()C", ref global::java.text.StringCharacterIterator._m4);
		}
		public new int Index
		{
			get
			{
				return getIndex();
			}
			set
			{
				setIndex(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public int getIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.StringCharacterIterator.staticClass, "getIndex", "()I", ref global::java.text.StringCharacterIterator._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public char current()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.StringCharacterIterator.staticClass, "current", "()C", ref global::java.text.StringCharacterIterator._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public char setIndex(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.StringCharacterIterator.staticClass, "setIndex", "(I)C", ref global::java.text.StringCharacterIterator._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int BeginIndex
		{
			get
			{
				return getBeginIndex();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public int getBeginIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.StringCharacterIterator.staticClass, "getBeginIndex", "()I", ref global::java.text.StringCharacterIterator._m8);
		}
		public new int EndIndex
		{
			get
			{
				return getEndIndex();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public int getEndIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.StringCharacterIterator.staticClass, "getEndIndex", "()I", ref global::java.text.StringCharacterIterator._m9);
		}
		public new global::java.lang.String Text
		{
			set
			{
				setText(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public void setText(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.StringCharacterIterator.staticClass, "setText", "(Ljava/lang/String;)V", ref global::java.text.StringCharacterIterator._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public char last()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.StringCharacterIterator.staticClass, "last", "()C", ref global::java.text.StringCharacterIterator._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public char first()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.StringCharacterIterator.staticClass, "first", "()C", ref global::java.text.StringCharacterIterator._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public StringCharacterIterator(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.StringCharacterIterator._m13.native == global::System.IntPtr.Zero)
				global::java.text.StringCharacterIterator._m13 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public StringCharacterIterator(java.lang.String arg0, int arg1, int arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.StringCharacterIterator._m14.native == global::System.IntPtr.Zero)
				global::java.text.StringCharacterIterator._m14 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "<init>", "(Ljava/lang/String;III)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public StringCharacterIterator(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.StringCharacterIterator._m15.native == global::System.IntPtr.Zero)
				global::java.text.StringCharacterIterator._m15 = @__env.GetMethodIDNoThrow(global::java.text.StringCharacterIterator.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.StringCharacterIterator.staticClass, global::java.text.StringCharacterIterator._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static StringCharacterIterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.StringCharacterIterator.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/StringCharacterIterator"));
		}
	}
}
