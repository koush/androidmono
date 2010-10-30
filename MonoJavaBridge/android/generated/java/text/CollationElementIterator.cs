namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class CollationElementIterator : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CollationElementIterator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _next25280;
		public int next()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.CollationElementIterator.staticClass, "next", "()I", ref global::java.text.CollationElementIterator._next25280);
		}
		internal static global::MonoJavaBridge.MethodId _previous25281;
		public int previous()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.CollationElementIterator.staticClass, "previous", "()I", ref global::java.text.CollationElementIterator._previous25281);
		}
		internal static global::MonoJavaBridge.MethodId _reset25282;
		public void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.CollationElementIterator.staticClass, "reset", "()V", ref global::java.text.CollationElementIterator._reset25282);
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
		internal static global::MonoJavaBridge.MethodId _getOffset25283;
		public int getOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.CollationElementIterator.staticClass, "getOffset", "()I", ref global::java.text.CollationElementIterator._getOffset25283);
		}
		internal static global::MonoJavaBridge.MethodId _setOffset25284;
		public void setOffset(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.CollationElementIterator.staticClass, "setOffset", "(I)V", ref global::java.text.CollationElementIterator._setOffset25284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setText25285;
		public void setText(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.CollationElementIterator.staticClass, "setText", "(Ljava/lang/String;)V", ref global::java.text.CollationElementIterator._setText25285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setText25286;
		public void setText(java.text.CharacterIterator arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.CollationElementIterator.staticClass, "setText", "(Ljava/text/CharacterIterator;)V", ref global::java.text.CollationElementIterator._setText25286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _primaryOrder25287;
		public static int primaryOrder(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.CollationElementIterator._primaryOrder25287.native == global::System.IntPtr.Zero)
				global::java.text.CollationElementIterator._primaryOrder25287 = @__env.GetStaticMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "primaryOrder", "(I)I");
			return @__env.CallStaticIntMethod(java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._primaryOrder25287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _secondaryOrder25288;
		public static short secondaryOrder(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.CollationElementIterator._secondaryOrder25288.native == global::System.IntPtr.Zero)
				global::java.text.CollationElementIterator._secondaryOrder25288 = @__env.GetStaticMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "secondaryOrder", "(I)S");
			return @__env.CallStaticShortMethod(java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._secondaryOrder25288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tertiaryOrder25289;
		public static short tertiaryOrder(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.CollationElementIterator._tertiaryOrder25289.native == global::System.IntPtr.Zero)
				global::java.text.CollationElementIterator._tertiaryOrder25289 = @__env.GetStaticMethodIDNoThrow(global::java.text.CollationElementIterator.staticClass, "tertiaryOrder", "(I)S");
			return @__env.CallStaticShortMethod(java.text.CollationElementIterator.staticClass, global::java.text.CollationElementIterator._tertiaryOrder25289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxExpansion25290;
		public int getMaxExpansion(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.CollationElementIterator.staticClass, "getMaxExpansion", "(I)I", ref global::java.text.CollationElementIterator._getMaxExpansion25290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static void InitJNI()
		{
		}
	}
}
