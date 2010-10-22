namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ThreadGroup : java.lang.Object, java.lang.Thread.UncaughtExceptionHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ThreadGroup()
		{
			InitJNI();
		}
		protected ThreadGroup(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _uncaughtException20756;
		public virtual void uncaughtException(java.lang.Thread arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup._uncaughtException20756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._uncaughtException20756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _toString20757;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ThreadGroup._toString20757)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._toString20757)) as java.lang.String;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName20758;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ThreadGroup._getName20758)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._getName20758)) as java.lang.String;
		}
		public new global::java.lang.ThreadGroup Parent
		{
			get
			{
				return getParent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParent20759;
		public virtual global::java.lang.ThreadGroup getParent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ThreadGroup._getParent20759)) as java.lang.ThreadGroup;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._getParent20759)) as java.lang.ThreadGroup;
		}
		internal static global::MonoJavaBridge.MethodId _setDaemon20760;
		public virtual void setDaemon(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup._setDaemon20760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._setDaemon20760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stop20761;
		public virtual void stop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup._stop20761);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._stop20761);
		}
		internal static global::MonoJavaBridge.MethodId _interrupt20762;
		public virtual void interrupt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup._interrupt20762);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._interrupt20762);
		}
		internal static global::MonoJavaBridge.MethodId _destroy20763;
		public virtual void destroy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup._destroy20763);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._destroy20763);
		}
		internal static global::MonoJavaBridge.MethodId _suspend20764;
		public virtual void suspend() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup._suspend20764);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._suspend20764);
		}
		internal static global::MonoJavaBridge.MethodId _resume20765;
		public virtual void resume() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup._resume20765);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._resume20765);
		}
		internal static global::MonoJavaBridge.MethodId _activeCount20766;
		public virtual int activeCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.ThreadGroup._activeCount20766);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._activeCount20766);
		}
		internal static global::MonoJavaBridge.MethodId _enumerate20767;
		public virtual int enumerate(java.lang.ThreadGroup[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.ThreadGroup._enumerate20767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._enumerate20767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _enumerate20768;
		public virtual int enumerate(java.lang.ThreadGroup[] arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.ThreadGroup._enumerate20768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._enumerate20768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _enumerate20769;
		public virtual int enumerate(java.lang.Thread[] arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.ThreadGroup._enumerate20769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._enumerate20769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _enumerate20770;
		public virtual int enumerate(java.lang.Thread[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.ThreadGroup._enumerate20770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._enumerate20770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDaemon20771;
		public virtual bool isDaemon() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.ThreadGroup._isDaemon20771);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._isDaemon20771);
		}
		internal static global::MonoJavaBridge.MethodId _checkAccess20772;
		public virtual void checkAccess() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup._checkAccess20772);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._checkAccess20772);
		}
		public new int MaxPriority
		{
			get
			{
				return getMaxPriority();
			}
			set
			{
				setMaxPriority(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaxPriority20773;
		public virtual int getMaxPriority() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.ThreadGroup._getMaxPriority20773);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._getMaxPriority20773);
		}
		internal static global::MonoJavaBridge.MethodId _isDestroyed20774;
		public virtual bool isDestroyed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.ThreadGroup._isDestroyed20774);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._isDestroyed20774);
		}
		internal static global::MonoJavaBridge.MethodId _setMaxPriority20775;
		public virtual void setMaxPriority(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup._setMaxPriority20775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._setMaxPriority20775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parentOf20776;
		public virtual bool parentOf(java.lang.ThreadGroup arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.ThreadGroup._parentOf20776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._parentOf20776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _activeGroupCount20777;
		public virtual int activeGroupCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.ThreadGroup._activeGroupCount20777);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._activeGroupCount20777);
		}
		internal static global::MonoJavaBridge.MethodId _list20778;
		public virtual void list() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup._list20778);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._list20778);
		}
		internal static global::MonoJavaBridge.MethodId _allowThreadSuspension20779;
		public virtual bool allowThreadSuspension(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.ThreadGroup._allowThreadSuspension20779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._allowThreadSuspension20779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ThreadGroup20780;
		public ThreadGroup(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._ThreadGroup20780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ThreadGroup20781;
		public ThreadGroup(java.lang.ThreadGroup arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._ThreadGroup20781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ThreadGroup.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ThreadGroup"));
			global::java.lang.ThreadGroup._uncaughtException20756 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V");
			global::java.lang.ThreadGroup._toString20757 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.ThreadGroup._getName20758 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "getName", "()Ljava/lang/String;");
			global::java.lang.ThreadGroup._getParent20759 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "getParent", "()Ljava/lang/ThreadGroup;");
			global::java.lang.ThreadGroup._setDaemon20760 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "setDaemon", "(Z)V");
			global::java.lang.ThreadGroup._stop20761 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "stop", "()V");
			global::java.lang.ThreadGroup._interrupt20762 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "interrupt", "()V");
			global::java.lang.ThreadGroup._destroy20763 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "destroy", "()V");
			global::java.lang.ThreadGroup._suspend20764 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "suspend", "()V");
			global::java.lang.ThreadGroup._resume20765 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "resume", "()V");
			global::java.lang.ThreadGroup._activeCount20766 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "activeCount", "()I");
			global::java.lang.ThreadGroup._enumerate20767 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/ThreadGroup;)I");
			global::java.lang.ThreadGroup._enumerate20768 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/ThreadGroup;Z)I");
			global::java.lang.ThreadGroup._enumerate20769 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/Thread;Z)I");
			global::java.lang.ThreadGroup._enumerate20770 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/Thread;)I");
			global::java.lang.ThreadGroup._isDaemon20771 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "isDaemon", "()Z");
			global::java.lang.ThreadGroup._checkAccess20772 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "checkAccess", "()V");
			global::java.lang.ThreadGroup._getMaxPriority20773 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "getMaxPriority", "()I");
			global::java.lang.ThreadGroup._isDestroyed20774 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "isDestroyed", "()Z");
			global::java.lang.ThreadGroup._setMaxPriority20775 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "setMaxPriority", "(I)V");
			global::java.lang.ThreadGroup._parentOf20776 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "parentOf", "(Ljava/lang/ThreadGroup;)Z");
			global::java.lang.ThreadGroup._activeGroupCount20777 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "activeGroupCount", "()I");
			global::java.lang.ThreadGroup._list20778 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "list", "()V");
			global::java.lang.ThreadGroup._allowThreadSuspension20779 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "allowThreadSuspension", "(Z)Z");
			global::java.lang.ThreadGroup._ThreadGroup20780 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.ThreadGroup._ThreadGroup20781 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/String;)V");
		}
	}
}
