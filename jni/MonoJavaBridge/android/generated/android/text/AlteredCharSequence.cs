namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AlteredCharSequence : java.lang.Object, java.lang.CharSequence, GetChars
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AlteredCharSequence()
		{
			InitJNI();
		}
		protected AlteredCharSequence(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString8131;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.AlteredCharSequence._toString8131)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.AlteredCharSequence.staticClass, global::android.text.AlteredCharSequence._toString8131)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length8132;
		public virtual int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.AlteredCharSequence._length8132);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.AlteredCharSequence.staticClass, global::android.text.AlteredCharSequence._length8132);
		}
		internal static global::MonoJavaBridge.MethodId _charAt8133;
		public virtual char charAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.text.AlteredCharSequence._charAt8133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.text.AlteredCharSequence.staticClass, global::android.text.AlteredCharSequence._charAt8133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChars8134;
		public virtual void getChars(int arg0, int arg1, char[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.AlteredCharSequence._getChars8134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.AlteredCharSequence.staticClass, global::android.text.AlteredCharSequence._getChars8134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _subSequence8135;
		public virtual global::java.lang.CharSequence subSequence(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.AlteredCharSequence._subSequence8135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.AlteredCharSequence.staticClass, global::android.text.AlteredCharSequence._subSequence8135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _make8136;
		public static global::android.text.AlteredCharSequence make(java.lang.CharSequence arg0, char[] arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.AlteredCharSequence.staticClass, global::android.text.AlteredCharSequence._make8136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.text.AlteredCharSequence;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.AlteredCharSequence.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/AlteredCharSequence"));
			global::android.text.AlteredCharSequence._toString8131 = @__env.GetMethodIDNoThrow(global::android.text.AlteredCharSequence.staticClass, "toString", "()Ljava/lang/String;");
			global::android.text.AlteredCharSequence._length8132 = @__env.GetMethodIDNoThrow(global::android.text.AlteredCharSequence.staticClass, "length", "()I");
			global::android.text.AlteredCharSequence._charAt8133 = @__env.GetMethodIDNoThrow(global::android.text.AlteredCharSequence.staticClass, "charAt", "(I)C");
			global::android.text.AlteredCharSequence._getChars8134 = @__env.GetMethodIDNoThrow(global::android.text.AlteredCharSequence.staticClass, "getChars", "(II[CI)V");
			global::android.text.AlteredCharSequence._subSequence8135 = @__env.GetMethodIDNoThrow(global::android.text.AlteredCharSequence.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			global::android.text.AlteredCharSequence._make8136 = @__env.GetStaticMethodIDNoThrow(global::android.text.AlteredCharSequence.staticClass, "make", "(Ljava/lang/CharSequence;[CII)Landroid/text/AlteredCharSequence;");
		}
	}
}
