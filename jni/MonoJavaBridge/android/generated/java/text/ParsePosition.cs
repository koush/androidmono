namespace java.text
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ParsePosition : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static ParsePosition()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.text.ParsePosition), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.text.ParsePosition(@__env);
			}
		}
		protected ParsePosition(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals13480;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.text.ParsePosition._equals13480, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.text.ParsePosition.staticClass, global::java.text.ParsePosition._equals13480, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString13481;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.ParsePosition._toString13481));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.ParsePosition.staticClass, global::java.text.ParsePosition._toString13481));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode13482;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.text.ParsePosition._hashCode13482);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.text.ParsePosition.staticClass, global::java.text.ParsePosition._hashCode13482);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIndex13483;
		public virtual int getIndex() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.text.ParsePosition._getIndex13483);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.text.ParsePosition.staticClass, global::java.text.ParsePosition._getIndex13483);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIndex13484;
		public virtual void setIndex(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.text.ParsePosition._setIndex13484, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.text.ParsePosition.staticClass, global::java.text.ParsePosition._setIndex13484, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setErrorIndex13485;
		public virtual void setErrorIndex(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.text.ParsePosition._setErrorIndex13485, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.text.ParsePosition.staticClass, global::java.text.ParsePosition._setErrorIndex13485, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getErrorIndex13486;
		public virtual int getErrorIndex() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.text.ParsePosition._getErrorIndex13486);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.text.ParsePosition.staticClass, global::java.text.ParsePosition._getErrorIndex13486);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ParsePosition13487;
		public ParsePosition(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.text.ParsePosition.staticClass, global::java.text.ParsePosition._ParsePosition13487, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.text.ParsePosition.staticClass = @__class;
			global::java.text.ParsePosition._equals13480 = @__env.GetMethodID(global::java.text.ParsePosition.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.ParsePosition._toString13481 = @__env.GetMethodID(global::java.text.ParsePosition.staticClass, "toString", "()Ljava/lang/String;");
			global::java.text.ParsePosition._hashCode13482 = @__env.GetMethodID(global::java.text.ParsePosition.staticClass, "hashCode", "()I");
			global::java.text.ParsePosition._getIndex13483 = @__env.GetMethodID(global::java.text.ParsePosition.staticClass, "getIndex", "()I");
			global::java.text.ParsePosition._setIndex13484 = @__env.GetMethodID(global::java.text.ParsePosition.staticClass, "setIndex", "(I)V");
			global::java.text.ParsePosition._setErrorIndex13485 = @__env.GetMethodID(global::java.text.ParsePosition.staticClass, "setErrorIndex", "(I)V");
			global::java.text.ParsePosition._getErrorIndex13486 = @__env.GetMethodID(global::java.text.ParsePosition.staticClass, "getErrorIndex", "()I");
			global::java.text.ParsePosition._ParsePosition13487 = @__env.GetMethodID(global::java.text.ParsePosition.staticClass, "<init>", "(I)V");
		}
	}
}
