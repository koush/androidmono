namespace java.beans
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PropertyChangeSupport : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PropertyChangeSupport(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void addPropertyChangeListener(java.beans.PropertyChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.beans.PropertyChangeSupport.staticClass, "addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", ref global::java.beans.PropertyChangeSupport._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void addPropertyChangeListener(java.lang.String arg0, java.beans.PropertyChangeListener arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.beans.PropertyChangeSupport.staticClass, "addPropertyChangeListener", "(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V", ref global::java.beans.PropertyChangeSupport._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void removePropertyChangeListener(java.beans.PropertyChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.beans.PropertyChangeSupport.staticClass, "removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", ref global::java.beans.PropertyChangeSupport._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void removePropertyChangeListener(java.lang.String arg0, java.beans.PropertyChangeListener arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.beans.PropertyChangeSupport.staticClass, "removePropertyChangeListener", "(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V", ref global::java.beans.PropertyChangeSupport._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.beans.PropertyChangeListener[] PropertyChangeListeners
		{
			get
			{
				return getPropertyChangeListeners();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.beans.PropertyChangeListener[] getPropertyChangeListeners()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.beans.PropertyChangeListener>(this, global::java.beans.PropertyChangeSupport.staticClass, "getPropertyChangeListeners", "()[Ljava/beans/PropertyChangeListener;", ref global::java.beans.PropertyChangeSupport._m4) as java.beans.PropertyChangeListener[];
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.beans.PropertyChangeListener[] getPropertyChangeListeners(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.beans.PropertyChangeListener>(this, global::java.beans.PropertyChangeSupport.staticClass, "getPropertyChangeListeners", "(Ljava/lang/String;)[Ljava/beans/PropertyChangeListener;", ref global::java.beans.PropertyChangeSupport._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.beans.PropertyChangeListener[];
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void firePropertyChange(java.lang.String arg0, bool arg1, bool arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.beans.PropertyChangeSupport.staticClass, "firePropertyChange", "(Ljava/lang/String;ZZ)V", ref global::java.beans.PropertyChangeSupport._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void firePropertyChange(java.beans.PropertyChangeEvent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.beans.PropertyChangeSupport.staticClass, "firePropertyChange", "(Ljava/beans/PropertyChangeEvent;)V", ref global::java.beans.PropertyChangeSupport._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void firePropertyChange(java.lang.String arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.beans.PropertyChangeSupport.staticClass, "firePropertyChange", "(Ljava/lang/String;II)V", ref global::java.beans.PropertyChangeSupport._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void firePropertyChange(java.lang.String arg0, java.lang.Object arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.beans.PropertyChangeSupport.staticClass, "firePropertyChange", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", ref global::java.beans.PropertyChangeSupport._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void fireIndexedPropertyChange(java.lang.String arg0, int arg1, bool arg2, bool arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.beans.PropertyChangeSupport.staticClass, "fireIndexedPropertyChange", "(Ljava/lang/String;IZZ)V", ref global::java.beans.PropertyChangeSupport._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void fireIndexedPropertyChange(java.lang.String arg0, int arg1, java.lang.Object arg2, java.lang.Object arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.beans.PropertyChangeSupport.staticClass, "fireIndexedPropertyChange", "(Ljava/lang/String;ILjava/lang/Object;Ljava/lang/Object;)V", ref global::java.beans.PropertyChangeSupport._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void fireIndexedPropertyChange(java.lang.String arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.beans.PropertyChangeSupport.staticClass, "fireIndexedPropertyChange", "(Ljava/lang/String;III)V", ref global::java.beans.PropertyChangeSupport._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual bool hasListeners(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.beans.PropertyChangeSupport.staticClass, "hasListeners", "(Ljava/lang/String;)Z", ref global::java.beans.PropertyChangeSupport._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public PropertyChangeSupport(java.lang.Object arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.beans.PropertyChangeSupport._m14.native == global::System.IntPtr.Zero)
				global::java.beans.PropertyChangeSupport._m14 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeSupport.staticClass, "<init>", "(Ljava/lang/Object;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.beans.PropertyChangeSupport.staticClass, global::java.beans.PropertyChangeSupport._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static PropertyChangeSupport()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.beans.PropertyChangeSupport.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/beans/PropertyChangeSupport"));
		}
	}
}
