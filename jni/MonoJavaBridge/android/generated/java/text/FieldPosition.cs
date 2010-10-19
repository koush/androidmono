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
		internal static global::MonoJavaBridge.MethodId _equals19614;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.FieldPosition._equals19614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.FieldPosition.staticClass, global::java.text.FieldPosition._equals19614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString19615;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.FieldPosition._toString19615)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.FieldPosition.staticClass, global::java.text.FieldPosition._toString19615)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19616;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.FieldPosition._hashCode19616);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.FieldPosition.staticClass, global::java.text.FieldPosition._hashCode19616);
		}
		public new int Field
		{
			get
			{
				return getField();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getField19617;
		public virtual int getField() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.FieldPosition._getField19617);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.FieldPosition.staticClass, global::java.text.FieldPosition._getField19617);
		}
		public new int BeginIndex
		{
			get
			{
				return getBeginIndex();
			}
			set
			{
				setBeginIndex(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBeginIndex19618;
		public virtual int getBeginIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.FieldPosition._getBeginIndex19618);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.FieldPosition.staticClass, global::java.text.FieldPosition._getBeginIndex19618);
		}
		public new int EndIndex
		{
			get
			{
				return getEndIndex();
			}
			set
			{
				setEndIndex(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEndIndex19619;
		public virtual int getEndIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.FieldPosition._getEndIndex19619);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.FieldPosition.staticClass, global::java.text.FieldPosition._getEndIndex19619);
		}
		public new global::java.text.Format.Field FieldAttribute
		{
			get
			{
				return getFieldAttribute();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFieldAttribute19620;
		public virtual global::java.text.Format.Field getFieldAttribute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.FieldPosition._getFieldAttribute19620)) as java.text.Format.Field;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.FieldPosition.staticClass, global::java.text.FieldPosition._getFieldAttribute19620)) as java.text.Format.Field;
		}
		internal static global::MonoJavaBridge.MethodId _setBeginIndex19621;
		public virtual void setBeginIndex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.FieldPosition._setBeginIndex19621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.FieldPosition.staticClass, global::java.text.FieldPosition._setBeginIndex19621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEndIndex19622;
		public virtual void setEndIndex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.FieldPosition._setEndIndex19622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.FieldPosition.staticClass, global::java.text.FieldPosition._setEndIndex19622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _FieldPosition19623;
		public FieldPosition(java.text.Format.Field arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.FieldPosition.staticClass, global::java.text.FieldPosition._FieldPosition19623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FieldPosition19624;
		public FieldPosition(java.text.Format.Field arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.FieldPosition.staticClass, global::java.text.FieldPosition._FieldPosition19624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FieldPosition19625;
		public FieldPosition(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.FieldPosition.staticClass, global::java.text.FieldPosition._FieldPosition19625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.FieldPosition.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/FieldPosition"));
			global::java.text.FieldPosition._equals19614 = @__env.GetMethodIDNoThrow(global::java.text.FieldPosition.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.FieldPosition._toString19615 = @__env.GetMethodIDNoThrow(global::java.text.FieldPosition.staticClass, "toString", "()Ljava/lang/String;");
			global::java.text.FieldPosition._hashCode19616 = @__env.GetMethodIDNoThrow(global::java.text.FieldPosition.staticClass, "hashCode", "()I");
			global::java.text.FieldPosition._getField19617 = @__env.GetMethodIDNoThrow(global::java.text.FieldPosition.staticClass, "getField", "()I");
			global::java.text.FieldPosition._getBeginIndex19618 = @__env.GetMethodIDNoThrow(global::java.text.FieldPosition.staticClass, "getBeginIndex", "()I");
			global::java.text.FieldPosition._getEndIndex19619 = @__env.GetMethodIDNoThrow(global::java.text.FieldPosition.staticClass, "getEndIndex", "()I");
			global::java.text.FieldPosition._getFieldAttribute19620 = @__env.GetMethodIDNoThrow(global::java.text.FieldPosition.staticClass, "getFieldAttribute", "()Ljava/text/Format$Field;");
			global::java.text.FieldPosition._setBeginIndex19621 = @__env.GetMethodIDNoThrow(global::java.text.FieldPosition.staticClass, "setBeginIndex", "(I)V");
			global::java.text.FieldPosition._setEndIndex19622 = @__env.GetMethodIDNoThrow(global::java.text.FieldPosition.staticClass, "setEndIndex", "(I)V");
			global::java.text.FieldPosition._FieldPosition19623 = @__env.GetMethodIDNoThrow(global::java.text.FieldPosition.staticClass, "<init>", "(Ljava/text/Format$Field;)V");
			global::java.text.FieldPosition._FieldPosition19624 = @__env.GetMethodIDNoThrow(global::java.text.FieldPosition.staticClass, "<init>", "(Ljava/text/Format$Field;I)V");
			global::java.text.FieldPosition._FieldPosition19625 = @__env.GetMethodIDNoThrow(global::java.text.FieldPosition.staticClass, "<init>", "(I)V");
		}
	}
}
