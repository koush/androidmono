namespace java.text
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class FieldPosition : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static FieldPosition()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.text.FieldPosition), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.text.FieldPosition(@__env);
			}
		}
		protected FieldPosition(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals13422;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.text.FieldPosition._equals13422, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.text.FieldPosition.staticClass, global::java.text.FieldPosition._equals13422, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString13423;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.FieldPosition._toString13423));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.FieldPosition.staticClass, global::java.text.FieldPosition._toString13423));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode13424;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.text.FieldPosition._hashCode13424);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.text.FieldPosition.staticClass, global::java.text.FieldPosition._hashCode13424);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getField13425;
		public virtual int getField() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.text.FieldPosition._getField13425);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.text.FieldPosition.staticClass, global::java.text.FieldPosition._getField13425);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBeginIndex13426;
		public virtual int getBeginIndex() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.text.FieldPosition._getBeginIndex13426);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.text.FieldPosition.staticClass, global::java.text.FieldPosition._getBeginIndex13426);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEndIndex13427;
		public virtual int getEndIndex() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.text.FieldPosition._getEndIndex13427);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.text.FieldPosition.staticClass, global::java.text.FieldPosition._getEndIndex13427);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFieldAttribute13428;
		public virtual global::java.text.Format.Field getFieldAttribute() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.Format.Field>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.FieldPosition._getFieldAttribute13428));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.Format.Field>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.FieldPosition.staticClass, global::java.text.FieldPosition._getFieldAttribute13428));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setBeginIndex13429;
		public virtual void setBeginIndex(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.text.FieldPosition._setBeginIndex13429, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.text.FieldPosition.staticClass, global::java.text.FieldPosition._setBeginIndex13429, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEndIndex13430;
		public virtual void setEndIndex(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.text.FieldPosition._setEndIndex13430, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.text.FieldPosition.staticClass, global::java.text.FieldPosition._setEndIndex13430, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _FieldPosition13431;
		public FieldPosition(java.text.Format.Field arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.text.FieldPosition.staticClass, global::java.text.FieldPosition._FieldPosition13431, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _FieldPosition13432;
		public FieldPosition(java.text.Format.Field arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.text.FieldPosition.staticClass, global::java.text.FieldPosition._FieldPosition13432, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _FieldPosition13433;
		public FieldPosition(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.text.FieldPosition.staticClass, global::java.text.FieldPosition._FieldPosition13433, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.text.FieldPosition.staticClass = @__class;
			global::java.text.FieldPosition._equals13422 = @__env.GetMethodID(global::java.text.FieldPosition.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.FieldPosition._toString13423 = @__env.GetMethodID(global::java.text.FieldPosition.staticClass, "toString", "()Ljava/lang/String;");
			global::java.text.FieldPosition._hashCode13424 = @__env.GetMethodID(global::java.text.FieldPosition.staticClass, "hashCode", "()I");
			global::java.text.FieldPosition._getField13425 = @__env.GetMethodID(global::java.text.FieldPosition.staticClass, "getField", "()I");
			global::java.text.FieldPosition._getBeginIndex13426 = @__env.GetMethodID(global::java.text.FieldPosition.staticClass, "getBeginIndex", "()I");
			global::java.text.FieldPosition._getEndIndex13427 = @__env.GetMethodID(global::java.text.FieldPosition.staticClass, "getEndIndex", "()I");
			global::java.text.FieldPosition._getFieldAttribute13428 = @__env.GetMethodID(global::java.text.FieldPosition.staticClass, "getFieldAttribute", "()Ljava/text/Format$Field;");
			global::java.text.FieldPosition._setBeginIndex13429 = @__env.GetMethodID(global::java.text.FieldPosition.staticClass, "setBeginIndex", "(I)V");
			global::java.text.FieldPosition._setEndIndex13430 = @__env.GetMethodID(global::java.text.FieldPosition.staticClass, "setEndIndex", "(I)V");
			global::java.text.FieldPosition._FieldPosition13431 = @__env.GetMethodID(global::java.text.FieldPosition.staticClass, "<init>", "(Ljava/text/Format$Field;)V");
			global::java.text.FieldPosition._FieldPosition13432 = @__env.GetMethodID(global::java.text.FieldPosition.staticClass, "<init>", "(Ljava/text/Format$Field;I)V");
			global::java.text.FieldPosition._FieldPosition13433 = @__env.GetMethodID(global::java.text.FieldPosition.staticClass, "<init>", "(I)V");
		}
	}
}
