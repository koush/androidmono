namespace java.beans
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PropertyChangeSupport : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PropertyChangeSupport()
		{
			InitJNI();
		}
		protected PropertyChangeSupport(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _addPropertyChangeListener18667;
		public virtual void addPropertyChangeListener(java.beans.PropertyChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._addPropertyChangeListener18667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._addPropertyChangeListener18667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addPropertyChangeListener18668;
		public virtual void addPropertyChangeListener(java.lang.String arg0, java.beans.PropertyChangeListener arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._addPropertyChangeListener18668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._addPropertyChangeListener18668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removePropertyChangeListener18669;
		public virtual void removePropertyChangeListener(java.beans.PropertyChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._removePropertyChangeListener18669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._removePropertyChangeListener18669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removePropertyChangeListener18670;
		public virtual void removePropertyChangeListener(java.lang.String arg0, java.beans.PropertyChangeListener arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._removePropertyChangeListener18670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._removePropertyChangeListener18670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.beans.PropertyChangeListener[] PropertyChangeListeners
		{
			get
			{
				return getPropertyChangeListeners();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPropertyChangeListeners18671;
		public virtual global::java.beans.PropertyChangeListener[] getPropertyChangeListeners() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.beans.PropertyChangeListener>(@__env.CallObjectMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._getPropertyChangeListeners18671)) as java.beans.PropertyChangeListener[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.beans.PropertyChangeListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._getPropertyChangeListeners18671)) as java.beans.PropertyChangeListener[];
		}
		internal static global::MonoJavaBridge.MethodId _getPropertyChangeListeners18672;
		public virtual global::java.beans.PropertyChangeListener[] getPropertyChangeListeners(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.beans.PropertyChangeListener>(@__env.CallObjectMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._getPropertyChangeListeners18672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.beans.PropertyChangeListener[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.beans.PropertyChangeListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._getPropertyChangeListeners18672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.beans.PropertyChangeListener[];
		}
		internal static global::MonoJavaBridge.MethodId _firePropertyChange18673;
		public virtual void firePropertyChange(java.lang.String arg0, bool arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._firePropertyChange18673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._firePropertyChange18673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _firePropertyChange18674;
		public virtual void firePropertyChange(java.beans.PropertyChangeEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._firePropertyChange18674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._firePropertyChange18674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _firePropertyChange18675;
		public virtual void firePropertyChange(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._firePropertyChange18675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._firePropertyChange18675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _firePropertyChange18676;
		public virtual void firePropertyChange(java.lang.String arg0, java.lang.Object arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._firePropertyChange18676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._firePropertyChange18676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _fireIndexedPropertyChange18677;
		public virtual void fireIndexedPropertyChange(java.lang.String arg0, int arg1, bool arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._fireIndexedPropertyChange18677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._fireIndexedPropertyChange18677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _fireIndexedPropertyChange18678;
		public virtual void fireIndexedPropertyChange(java.lang.String arg0, int arg1, java.lang.Object arg2, java.lang.Object arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._fireIndexedPropertyChange18678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._fireIndexedPropertyChange18678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _fireIndexedPropertyChange18679;
		public virtual void fireIndexedPropertyChange(java.lang.String arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._fireIndexedPropertyChange18679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._fireIndexedPropertyChange18679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _hasListeners18680;
		public virtual bool hasListeners(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._hasListeners18680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._hasListeners18680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PropertyChangeSupport18681;
		public PropertyChangeSupport(java.lang.Object arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._PropertyChangeSupport18681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.beans.PropertyChangeSupport.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/beans/PropertyChangeSupport"));
			global::java.beans.PropertyChangeSupport._addPropertyChangeListener18667 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V");
			global::java.beans.PropertyChangeSupport._addPropertyChangeListener18668 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "addPropertyChangeListener", "(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V");
			global::java.beans.PropertyChangeSupport._removePropertyChangeListener18669 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V");
			global::java.beans.PropertyChangeSupport._removePropertyChangeListener18670 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "removePropertyChangeListener", "(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V");
			global::java.beans.PropertyChangeSupport._getPropertyChangeListeners18671 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "getPropertyChangeListeners", "()[Ljava/beans/PropertyChangeListener;");
			global::java.beans.PropertyChangeSupport._getPropertyChangeListeners18672 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "getPropertyChangeListeners", "(Ljava/lang/String;)[Ljava/beans/PropertyChangeListener;");
			global::java.beans.PropertyChangeSupport._firePropertyChange18673 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "firePropertyChange", "(Ljava/lang/String;ZZ)V");
			global::java.beans.PropertyChangeSupport._firePropertyChange18674 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "firePropertyChange", "(Ljava/beans/PropertyChangeEvent;)V");
			global::java.beans.PropertyChangeSupport._firePropertyChange18675 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "firePropertyChange", "(Ljava/lang/String;II)V");
			global::java.beans.PropertyChangeSupport._firePropertyChange18676 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "firePropertyChange", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
			global::java.beans.PropertyChangeSupport._fireIndexedPropertyChange18677 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "fireIndexedPropertyChange", "(Ljava/lang/String;IZZ)V");
			global::java.beans.PropertyChangeSupport._fireIndexedPropertyChange18678 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "fireIndexedPropertyChange", "(Ljava/lang/String;ILjava/lang/Object;Ljava/lang/Object;)V");
			global::java.beans.PropertyChangeSupport._fireIndexedPropertyChange18679 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "fireIndexedPropertyChange", "(Ljava/lang/String;III)V");
			global::java.beans.PropertyChangeSupport._hasListeners18680 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "hasListeners", "(Ljava/lang/String;)Z");
			global::java.beans.PropertyChangeSupport._PropertyChangeSupport18681 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "<init>", "(Ljava/lang/Object;)V");
		}
	}
}
