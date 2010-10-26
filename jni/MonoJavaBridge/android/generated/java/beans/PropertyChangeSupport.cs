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
		internal static global::MonoJavaBridge.MethodId _addPropertyChangeListener18785;
		public virtual void addPropertyChangeListener(java.beans.PropertyChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._addPropertyChangeListener18785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._addPropertyChangeListener18785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addPropertyChangeListener18786;
		public virtual void addPropertyChangeListener(java.lang.String arg0, java.beans.PropertyChangeListener arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._addPropertyChangeListener18786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._addPropertyChangeListener18786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removePropertyChangeListener18787;
		public virtual void removePropertyChangeListener(java.beans.PropertyChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._removePropertyChangeListener18787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._removePropertyChangeListener18787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removePropertyChangeListener18788;
		public virtual void removePropertyChangeListener(java.lang.String arg0, java.beans.PropertyChangeListener arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._removePropertyChangeListener18788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._removePropertyChangeListener18788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.beans.PropertyChangeListener[] PropertyChangeListeners
		{
			get
			{
				return getPropertyChangeListeners();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPropertyChangeListeners18789;
		public virtual global::java.beans.PropertyChangeListener[] getPropertyChangeListeners() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.beans.PropertyChangeListener>(@__env.CallObjectMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._getPropertyChangeListeners18789)) as java.beans.PropertyChangeListener[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.beans.PropertyChangeListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._getPropertyChangeListeners18789)) as java.beans.PropertyChangeListener[];
		}
		internal static global::MonoJavaBridge.MethodId _getPropertyChangeListeners18790;
		public virtual global::java.beans.PropertyChangeListener[] getPropertyChangeListeners(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.beans.PropertyChangeListener>(@__env.CallObjectMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._getPropertyChangeListeners18790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.beans.PropertyChangeListener[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.beans.PropertyChangeListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._getPropertyChangeListeners18790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.beans.PropertyChangeListener[];
		}
		internal static global::MonoJavaBridge.MethodId _firePropertyChange18791;
		public virtual void firePropertyChange(java.lang.String arg0, bool arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._firePropertyChange18791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._firePropertyChange18791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _firePropertyChange18792;
		public virtual void firePropertyChange(java.beans.PropertyChangeEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._firePropertyChange18792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._firePropertyChange18792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _firePropertyChange18793;
		public virtual void firePropertyChange(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._firePropertyChange18793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._firePropertyChange18793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _firePropertyChange18794;
		public virtual void firePropertyChange(java.lang.String arg0, java.lang.Object arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._firePropertyChange18794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._firePropertyChange18794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _fireIndexedPropertyChange18795;
		public virtual void fireIndexedPropertyChange(java.lang.String arg0, int arg1, bool arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._fireIndexedPropertyChange18795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._fireIndexedPropertyChange18795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _fireIndexedPropertyChange18796;
		public virtual void fireIndexedPropertyChange(java.lang.String arg0, int arg1, java.lang.Object arg2, java.lang.Object arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._fireIndexedPropertyChange18796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._fireIndexedPropertyChange18796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _fireIndexedPropertyChange18797;
		public virtual void fireIndexedPropertyChange(java.lang.String arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._fireIndexedPropertyChange18797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._fireIndexedPropertyChange18797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _hasListeners18798;
		public virtual bool hasListeners(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._hasListeners18798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._hasListeners18798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PropertyChangeSupport18799;
		public PropertyChangeSupport(java.lang.Object arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._PropertyChangeSupport18799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.beans.PropertyChangeSupport.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/beans/PropertyChangeSupport"));
			global::java.beans.PropertyChangeSupport._addPropertyChangeListener18785 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V");
			global::java.beans.PropertyChangeSupport._addPropertyChangeListener18786 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "addPropertyChangeListener", "(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V");
			global::java.beans.PropertyChangeSupport._removePropertyChangeListener18787 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V");
			global::java.beans.PropertyChangeSupport._removePropertyChangeListener18788 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "removePropertyChangeListener", "(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V");
			global::java.beans.PropertyChangeSupport._getPropertyChangeListeners18789 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "getPropertyChangeListeners", "()[Ljava/beans/PropertyChangeListener;");
			global::java.beans.PropertyChangeSupport._getPropertyChangeListeners18790 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "getPropertyChangeListeners", "(Ljava/lang/String;)[Ljava/beans/PropertyChangeListener;");
			global::java.beans.PropertyChangeSupport._firePropertyChange18791 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "firePropertyChange", "(Ljava/lang/String;ZZ)V");
			global::java.beans.PropertyChangeSupport._firePropertyChange18792 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "firePropertyChange", "(Ljava/beans/PropertyChangeEvent;)V");
			global::java.beans.PropertyChangeSupport._firePropertyChange18793 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "firePropertyChange", "(Ljava/lang/String;II)V");
			global::java.beans.PropertyChangeSupport._firePropertyChange18794 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "firePropertyChange", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
			global::java.beans.PropertyChangeSupport._fireIndexedPropertyChange18795 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "fireIndexedPropertyChange", "(Ljava/lang/String;IZZ)V");
			global::java.beans.PropertyChangeSupport._fireIndexedPropertyChange18796 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "fireIndexedPropertyChange", "(Ljava/lang/String;ILjava/lang/Object;Ljava/lang/Object;)V");
			global::java.beans.PropertyChangeSupport._fireIndexedPropertyChange18797 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "fireIndexedPropertyChange", "(Ljava/lang/String;III)V");
			global::java.beans.PropertyChangeSupport._hasListeners18798 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "hasListeners", "(Ljava/lang/String;)Z");
			global::java.beans.PropertyChangeSupport._PropertyChangeSupport18799 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "<init>", "(Ljava/lang/Object;)V");
		}
	}
}
