namespace java.beans
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PropertyChangeEvent : java.util.EventObject
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PropertyChangeEvent()
		{
			InitJNI();
		}
		protected PropertyChangeEvent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String PropertyName
		{
			get
			{
				return getPropertyName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPropertyName18775;
		public virtual global::java.lang.String getPropertyName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.beans.PropertyChangeEvent._getPropertyName18775)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.beans.PropertyChangeEvent.staticClass, global::java.beans.PropertyChangeEvent._getPropertyName18775)) as java.lang.String;
		}
		public new global::java.lang.Object NewValue
		{
			get
			{
				return getNewValue();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNewValue18776;
		public virtual global::java.lang.Object getNewValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.beans.PropertyChangeEvent._getNewValue18776)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.beans.PropertyChangeEvent.staticClass, global::java.beans.PropertyChangeEvent._getNewValue18776)) as java.lang.Object;
		}
		public new global::java.lang.Object OldValue
		{
			get
			{
				return getOldValue();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOldValue18777;
		public virtual global::java.lang.Object getOldValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.beans.PropertyChangeEvent._getOldValue18777)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.beans.PropertyChangeEvent.staticClass, global::java.beans.PropertyChangeEvent._getOldValue18777)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setPropagationId18778;
		public virtual void setPropagationId(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeEvent._setPropagationId18778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeEvent.staticClass, global::java.beans.PropertyChangeEvent._setPropagationId18778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.Object PropagationId
		{
			get
			{
				return getPropagationId();
			}
			set
			{
				setPropagationId(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPropagationId18779;
		public virtual global::java.lang.Object getPropagationId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.beans.PropertyChangeEvent._getPropagationId18779)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.beans.PropertyChangeEvent.staticClass, global::java.beans.PropertyChangeEvent._getPropagationId18779)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _PropertyChangeEvent18780;
		public PropertyChangeEvent(java.lang.Object arg0, java.lang.String arg1, java.lang.Object arg2, java.lang.Object arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.beans.PropertyChangeEvent.staticClass, global::java.beans.PropertyChangeEvent._PropertyChangeEvent18780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.beans.PropertyChangeEvent.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/beans/PropertyChangeEvent"));
			global::java.beans.PropertyChangeEvent._getPropertyName18775 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeEvent.staticClass, "getPropertyName", "()Ljava/lang/String;");
			global::java.beans.PropertyChangeEvent._getNewValue18776 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeEvent.staticClass, "getNewValue", "()Ljava/lang/Object;");
			global::java.beans.PropertyChangeEvent._getOldValue18777 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeEvent.staticClass, "getOldValue", "()Ljava/lang/Object;");
			global::java.beans.PropertyChangeEvent._setPropagationId18778 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeEvent.staticClass, "setPropagationId", "(Ljava/lang/Object;)V");
			global::java.beans.PropertyChangeEvent._getPropagationId18779 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeEvent.staticClass, "getPropagationId", "()Ljava/lang/Object;");
			global::java.beans.PropertyChangeEvent._PropertyChangeEvent18780 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeEvent.staticClass, "<init>", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
		}
	}
}
