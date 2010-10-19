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
		internal static global::MonoJavaBridge.MethodId _equals19718;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.ParsePosition._equals19718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.ParsePosition.staticClass, global::java.text.ParsePosition._equals19718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString19719;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.ParsePosition._toString19719)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.ParsePosition.staticClass, global::java.text.ParsePosition._toString19719)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19720;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.ParsePosition._hashCode19720);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.ParsePosition.staticClass, global::java.text.ParsePosition._hashCode19720);
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
		internal static global::MonoJavaBridge.MethodId _getIndex19721;
		public virtual int getIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.ParsePosition._getIndex19721);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.ParsePosition.staticClass, global::java.text.ParsePosition._getIndex19721);
		}
		internal static global::MonoJavaBridge.MethodId _setIndex19722;
		public virtual void setIndex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.ParsePosition._setIndex19722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.ParsePosition.staticClass, global::java.text.ParsePosition._setIndex19722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorIndex19723;
		public virtual void setErrorIndex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.ParsePosition._setErrorIndex19723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.ParsePosition.staticClass, global::java.text.ParsePosition._setErrorIndex19723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getErrorIndex19724;
		public virtual int getErrorIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.ParsePosition._getErrorIndex19724);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.ParsePosition.staticClass, global::java.text.ParsePosition._getErrorIndex19724);
		}
		internal static global::MonoJavaBridge.MethodId _ParsePosition19725;
		public ParsePosition(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.ParsePosition.staticClass, global::java.text.ParsePosition._ParsePosition19725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.ParsePosition.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/ParsePosition"));
			global::java.text.ParsePosition._equals19718 = @__env.GetMethodIDNoThrow(global::java.text.ParsePosition.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.ParsePosition._toString19719 = @__env.GetMethodIDNoThrow(global::java.text.ParsePosition.staticClass, "toString", "()Ljava/lang/String;");
			global::java.text.ParsePosition._hashCode19720 = @__env.GetMethodIDNoThrow(global::java.text.ParsePosition.staticClass, "hashCode", "()I");
			global::java.text.ParsePosition._getIndex19721 = @__env.GetMethodIDNoThrow(global::java.text.ParsePosition.staticClass, "getIndex", "()I");
			global::java.text.ParsePosition._setIndex19722 = @__env.GetMethodIDNoThrow(global::java.text.ParsePosition.staticClass, "setIndex", "(I)V");
			global::java.text.ParsePosition._setErrorIndex19723 = @__env.GetMethodIDNoThrow(global::java.text.ParsePosition.staticClass, "setErrorIndex", "(I)V");
			global::java.text.ParsePosition._getErrorIndex19724 = @__env.GetMethodIDNoThrow(global::java.text.ParsePosition.staticClass, "getErrorIndex", "()I");
			global::java.text.ParsePosition._ParsePosition19725 = @__env.GetMethodIDNoThrow(global::java.text.ParsePosition.staticClass, "<init>", "(I)V");
		}
	}
}
