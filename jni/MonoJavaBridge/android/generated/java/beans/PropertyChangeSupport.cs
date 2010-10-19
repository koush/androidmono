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
		internal static global::MonoJavaBridge.MethodId _addPropertyChangeListener13196;
		public virtual void addPropertyChangeListener(java.beans.PropertyChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._addPropertyChangeListener13196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._addPropertyChangeListener13196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addPropertyChangeListener13197;
		public virtual void addPropertyChangeListener(java.lang.String arg0, java.beans.PropertyChangeListener arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._addPropertyChangeListener13197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._addPropertyChangeListener13197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removePropertyChangeListener13198;
		public virtual void removePropertyChangeListener(java.beans.PropertyChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._removePropertyChangeListener13198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._removePropertyChangeListener13198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removePropertyChangeListener13199;
		public virtual void removePropertyChangeListener(java.lang.String arg0, java.beans.PropertyChangeListener arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._removePropertyChangeListener13199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._removePropertyChangeListener13199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.beans.PropertyChangeListener[] PropertyChangeListeners
		{
			get
			{
				return getPropertyChangeListeners();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPropertyChangeListeners13200;
		public virtual global::java.beans.PropertyChangeListener[] getPropertyChangeListeners() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.beans.PropertyChangeListener>(@__env.CallObjectMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._getPropertyChangeListeners13200)) as java.beans.PropertyChangeListener[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.beans.PropertyChangeListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._getPropertyChangeListeners13200)) as java.beans.PropertyChangeListener[];
		}
		internal static global::MonoJavaBridge.MethodId _getPropertyChangeListeners13201;
		public virtual global::java.beans.PropertyChangeListener[] getPropertyChangeListeners(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.beans.PropertyChangeListener>(@__env.CallObjectMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._getPropertyChangeListeners13201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.beans.PropertyChangeListener[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.beans.PropertyChangeListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._getPropertyChangeListeners13201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.beans.PropertyChangeListener[];
		}
		internal static global::MonoJavaBridge.MethodId _firePropertyChange13202;
		public virtual void firePropertyChange(java.lang.String arg0, bool arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._firePropertyChange13202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._firePropertyChange13202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _firePropertyChange13203;
		public virtual void firePropertyChange(java.beans.PropertyChangeEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._firePropertyChange13203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._firePropertyChange13203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _firePropertyChange13204;
		public virtual void firePropertyChange(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._firePropertyChange13204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._firePropertyChange13204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _firePropertyChange13205;
		public virtual void firePropertyChange(java.lang.String arg0, java.lang.Object arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._firePropertyChange13205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._firePropertyChange13205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _fireIndexedPropertyChange13206;
		public virtual void fireIndexedPropertyChange(java.lang.String arg0, int arg1, bool arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._fireIndexedPropertyChange13206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._fireIndexedPropertyChange13206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _fireIndexedPropertyChange13207;
		public virtual void fireIndexedPropertyChange(java.lang.String arg0, int arg1, java.lang.Object arg2, java.lang.Object arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._fireIndexedPropertyChange13207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._fireIndexedPropertyChange13207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _fireIndexedPropertyChange13208;
		public virtual void fireIndexedPropertyChange(java.lang.String arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._fireIndexedPropertyChange13208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._fireIndexedPropertyChange13208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _hasListeners13209;
		public virtual bool hasListeners(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport._hasListeners13209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._hasListeners13209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PropertyChangeSupport13210;
		public PropertyChangeSupport(java.lang.Object arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._PropertyChangeSupport13210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.beans.PropertyChangeSupport.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/beans/PropertyChangeSupport"));
			global::java.beans.PropertyChangeSupport._addPropertyChangeListener13196 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V");
			global::java.beans.PropertyChangeSupport._addPropertyChangeListener13197 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "addPropertyChangeListener", "(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V");
			global::java.beans.PropertyChangeSupport._removePropertyChangeListener13198 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V");
			global::java.beans.PropertyChangeSupport._removePropertyChangeListener13199 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "removePropertyChangeListener", "(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V");
			global::java.beans.PropertyChangeSupport._getPropertyChangeListeners13200 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "getPropertyChangeListeners", "()[Ljava/beans/PropertyChangeListener;");
			global::java.beans.PropertyChangeSupport._getPropertyChangeListeners13201 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "getPropertyChangeListeners", "(Ljava/lang/String;)[Ljava/beans/PropertyChangeListener;");
			global::java.beans.PropertyChangeSupport._firePropertyChange13202 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "firePropertyChange", "(Ljava/lang/String;ZZ)V");
			global::java.beans.PropertyChangeSupport._firePropertyChange13203 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "firePropertyChange", "(Ljava/beans/PropertyChangeEvent;)V");
			global::java.beans.PropertyChangeSupport._firePropertyChange13204 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "firePropertyChange", "(Ljava/lang/String;II)V");
			global::java.beans.PropertyChangeSupport._firePropertyChange13205 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "firePropertyChange", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V");
			global::java.beans.PropertyChangeSupport._fireIndexedPropertyChange13206 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "fireIndexedPropertyChange", "(Ljava/lang/String;IZZ)V");
			global::java.beans.PropertyChangeSupport._fireIndexedPropertyChange13207 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "fireIndexedPropertyChange", "(Ljava/lang/String;ILjava/lang/Object;Ljava/lang/Object;)V");
			global::java.beans.PropertyChangeSupport._fireIndexedPropertyChange13208 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "fireIndexedPropertyChange", "(Ljava/lang/String;III)V");
			global::java.beans.PropertyChangeSupport._hasListeners13209 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "hasListeners", "(Ljava/lang/String;)Z");
			global::java.beans.PropertyChangeSupport._PropertyChangeSupport13210 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "<init>", "(Ljava/lang/Object;)V");
		}
	}
}
