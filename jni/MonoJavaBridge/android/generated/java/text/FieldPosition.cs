namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FieldPosition : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FieldPosition()
		{
			InitJNI();
		}
		protected FieldPosition(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals15098;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.FieldPosition._equals15098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.FieldPosition.staticClass, global::java.text.FieldPosition._equals15098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString15099;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.FieldPosition._toString15099)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.FieldPosition.staticClass, global::java.text.FieldPosition._toString15099)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode15100;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.FieldPosition._hashCode15100);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.FieldPosition.staticClass, global::java.text.FieldPosition._hashCode15100);
		}
		internal static global::MonoJavaBridge.MethodId _getField15101;
		public virtual int getField() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.FieldPosition._getField15101);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.FieldPosition.staticClass, global::java.text.FieldPosition._getField15101);
		}
		internal static global::MonoJavaBridge.MethodId _getBeginIndex15102;
		public virtual int getBeginIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.FieldPosition._getBeginIndex15102);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.FieldPosition.staticClass, global::java.text.FieldPosition._getBeginIndex15102);
		}
		internal static global::MonoJavaBridge.MethodId _getEndIndex15103;
		public virtual int getEndIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.FieldPosition._getEndIndex15103);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.FieldPosition.staticClass, global::java.text.FieldPosition._getEndIndex15103);
		}
		internal static global::MonoJavaBridge.MethodId _getFieldAttribute15104;
		public virtual global::java.text.Format.Field getFieldAttribute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.FieldPosition._getFieldAttribute15104)) as java.text.Format.Field;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.FieldPosition.staticClass, global::java.text.FieldPosition._getFieldAttribute15104)) as java.text.Format.Field;
		}
		internal static global::MonoJavaBridge.MethodId _setBeginIndex15105;
		public virtual void setBeginIndex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.FieldPosition._setBeginIndex15105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.FieldPosition.staticClass, global::java.text.FieldPosition._setBeginIndex15105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEndIndex15106;
		public virtual void setEndIndex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.FieldPosition._setEndIndex15106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.FieldPosition.staticClass, global::java.text.FieldPosition._setEndIndex15106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _FieldPosition15107;
		public FieldPosition(java.text.Format.Field arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.FieldPosition.staticClass, global::java.text.FieldPosition._FieldPosition15107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FieldPosition15108;
		public FieldPosition(java.text.Format.Field arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.FieldPosition.staticClass, global::java.text.FieldPosition._FieldPosition15108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FieldPosition15109;
		public FieldPosition(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.FieldPosition.staticClass, global::java.text.FieldPosition._FieldPosition15109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.FieldPosition.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/FieldPosition"));
			global::java.text.FieldPosition._equals15098 = @__env.GetMethodIDNoThrow(global::java.text.FieldPosition.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.FieldPosition._toString15099 = @__env.GetMethodIDNoThrow(global::java.text.FieldPosition.staticClass, "toString", "()Ljava/lang/String;");
			global::java.text.FieldPosition._hashCode15100 = @__env.GetMethodIDNoThrow(global::java.text.FieldPosition.staticClass, "hashCode", "()I");
			global::java.text.FieldPosition._getField15101 = @__env.GetMethodIDNoThrow(global::java.text.FieldPosition.staticClass, "getField", "()I");
			global::java.text.FieldPosition._getBeginIndex15102 = @__env.GetMethodIDNoThrow(global::java.text.FieldPosition.staticClass, "getBeginIndex", "()I");
			global::java.text.FieldPosition._getEndIndex15103 = @__env.GetMethodIDNoThrow(global::java.text.FieldPosition.staticClass, "getEndIndex", "()I");
			global::java.text.FieldPosition._getFieldAttribute15104 = @__env.GetMethodIDNoThrow(global::java.text.FieldPosition.staticClass, "getFieldAttribute", "()Ljava/text/Format$Field;");
			global::java.text.FieldPosition._setBeginIndex15105 = @__env.GetMethodIDNoThrow(global::java.text.FieldPosition.staticClass, "setBeginIndex", "(I)V");
			global::java.text.FieldPosition._setEndIndex15106 = @__env.GetMethodIDNoThrow(global::java.text.FieldPosition.staticClass, "setEndIndex", "(I)V");
			global::java.text.FieldPosition._FieldPosition15107 = @__env.GetMethodIDNoThrow(global::java.text.FieldPosition.staticClass, "<init>", "(Ljava/text/Format$Field;)V");
			global::java.text.FieldPosition._FieldPosition15108 = @__env.GetMethodIDNoThrow(global::java.text.FieldPosition.staticClass, "<init>", "(Ljava/text/Format$Field;I)V");
			global::java.text.FieldPosition._FieldPosition15109 = @__env.GetMethodIDNoThrow(global::java.text.FieldPosition.staticClass, "<init>", "(I)V");
		}
	}
}
