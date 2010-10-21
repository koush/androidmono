namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ParsePosition : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ParsePosition()
		{
			InitJNI();
		}
		protected ParsePosition(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals25494;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.ParsePosition._equals25494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.ParsePosition.staticClass, global::java.text.ParsePosition._equals25494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString25495;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.ParsePosition._toString25495)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.ParsePosition.staticClass, global::java.text.ParsePosition._toString25495)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25496;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.ParsePosition._hashCode25496);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.ParsePosition.staticClass, global::java.text.ParsePosition._hashCode25496);
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
		internal static global::MonoJavaBridge.MethodId _getIndex25497;
		public virtual int getIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.ParsePosition._getIndex25497);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.ParsePosition.staticClass, global::java.text.ParsePosition._getIndex25497);
		}
		internal static global::MonoJavaBridge.MethodId _setIndex25498;
		public virtual void setIndex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.ParsePosition._setIndex25498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.ParsePosition.staticClass, global::java.text.ParsePosition._setIndex25498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorIndex25499;
		public virtual void setErrorIndex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.ParsePosition._setErrorIndex25499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.ParsePosition.staticClass, global::java.text.ParsePosition._setErrorIndex25499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ErrorIndex
		{
			get
			{
				return getErrorIndex();
			}
			set
			{
				setErrorIndex(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getErrorIndex25500;
		public virtual int getErrorIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.ParsePosition._getErrorIndex25500);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.ParsePosition.staticClass, global::java.text.ParsePosition._getErrorIndex25500);
		}
		internal static global::MonoJavaBridge.MethodId _ParsePosition25501;
		public ParsePosition(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.ParsePosition.staticClass, global::java.text.ParsePosition._ParsePosition25501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.ParsePosition.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/ParsePosition"));
			global::java.text.ParsePosition._equals25494 = @__env.GetMethodIDNoThrow(global::java.text.ParsePosition.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.ParsePosition._toString25495 = @__env.GetMethodIDNoThrow(global::java.text.ParsePosition.staticClass, "toString", "()Ljava/lang/String;");
			global::java.text.ParsePosition._hashCode25496 = @__env.GetMethodIDNoThrow(global::java.text.ParsePosition.staticClass, "hashCode", "()I");
			global::java.text.ParsePosition._getIndex25497 = @__env.GetMethodIDNoThrow(global::java.text.ParsePosition.staticClass, "getIndex", "()I");
			global::java.text.ParsePosition._setIndex25498 = @__env.GetMethodIDNoThrow(global::java.text.ParsePosition.staticClass, "setIndex", "(I)V");
			global::java.text.ParsePosition._setErrorIndex25499 = @__env.GetMethodIDNoThrow(global::java.text.ParsePosition.staticClass, "setErrorIndex", "(I)V");
			global::java.text.ParsePosition._getErrorIndex25500 = @__env.GetMethodIDNoThrow(global::java.text.ParsePosition.staticClass, "getErrorIndex", "()I");
			global::java.text.ParsePosition._ParsePosition25501 = @__env.GetMethodIDNoThrow(global::java.text.ParsePosition.staticClass, "<init>", "(I)V");
		}
	}
}
