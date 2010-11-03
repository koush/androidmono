namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class CollationElementIterator : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CollationElementIterator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public int next()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.CollationElementIterator.staticClass, "next", "()I", ref global::java.text.CollationElementIterator._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public int previous()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.CollationElementIterator.staticClass, "previous", "()I", ref global::java.text.CollationElementIterator._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.CollationElementIterator.staticClass, "reset", "()V", ref global::java.text.CollationElementIterator._m2);
		}
		public new int Offset
		{
			get
			{
				return getOffset();
			}
			set
			{
				setOffset(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public int getOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.CollationElementIterator.staticClass, "getOffset", "()I", ref global::java.text.CollationElementIterator._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public void setOffset(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.CollationElementIterator.staticClass, "setOffset", "(I)V", ref global::java.text.CollationElementIterator._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public void setText(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.CollationElementIterator.staticClass, "setText", "(Ljava/lang/String;)V", ref global::java.text.CollationElementIterator._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public void setText(java.text.CharacterIterator arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.CollationElementIterator.staticClass, "setText", "(Ljava/text/CharacterIterator;)V", ref global::java.text.CollationElementIterator._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static int primaryOrder(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.CollationElementIterator._m7.native == global::System.IntPtr.Zero)
				global::java.text.CollationElementIterator._m7 = @__env.GetStaticMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "primaryOrder", "(I)I");
			return @__env.CallStaticIntMethod(java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static short secondaryOrder(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.CollationElementIterator._m8.native == global::System.IntPtr.Zero)
				global::java.text.CollationElementIterator._m8 = @__env.GetStaticMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "secondaryOrder", "(I)S");
			return @__env.CallStaticShortMethod(java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static short tertiaryOrder(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.CollationElementIterator._m9.native == global::System.IntPtr.Zero)
				global::java.text.CollationElementIterator._m9 = @__env.GetStaticMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "tertiaryOrder", "(I)S");
			return @__env.CallStaticShortMethod(java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public int getMaxExpansion(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.CollationElementIterator.staticClass, "getMaxExpansion", "(I)I", ref global::java.text.CollationElementIterator._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int NULLORDER
		{
			get
			{
				return -1;
			}
		}
		static CollationElementIterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.CollationElementIterator.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/CollationElementIterator"));
		}
	}
}
