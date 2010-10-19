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
		internal static global::MonoJavaBridge.MethodId _uncaughtException15234;
		public virtual void uncaughtException(java.lang.Thread arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup._uncaughtException15234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._uncaughtException15234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _toString15235;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ThreadGroup._toString15235)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._toString15235)) as java.lang.String;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName15236;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ThreadGroup._getName15236)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._getName15236)) as java.lang.String;
		}
		public new global::java.lang.ThreadGroup Parent
		{
			get
			{
				return getParent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParent15237;
		public virtual global::java.lang.ThreadGroup getParent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ThreadGroup._getParent15237)) as java.lang.ThreadGroup;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._getParent15237)) as java.lang.ThreadGroup;
		}
		internal static global::MonoJavaBridge.MethodId _setDaemon15238;
		public virtual void setDaemon(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup._setDaemon15238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._setDaemon15238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stop15239;
		public virtual void stop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup._stop15239);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._stop15239);
		}
		internal static global::MonoJavaBridge.MethodId _interrupt15240;
		public virtual void interrupt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup._interrupt15240);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._interrupt15240);
		}
		internal static global::MonoJavaBridge.MethodId _destroy15241;
		public virtual void destroy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup._destroy15241);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._destroy15241);
		}
		internal static global::MonoJavaBridge.MethodId _suspend15242;
		public virtual void suspend() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup._suspend15242);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._suspend15242);
		}
		internal static global::MonoJavaBridge.MethodId _resume15243;
		public virtual void resume() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup._resume15243);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._resume15243);
		}
		internal static global::MonoJavaBridge.MethodId _activeCount15244;
		public virtual int activeCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.ThreadGroup._activeCount15244);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._activeCount15244);
		}
		internal static global::MonoJavaBridge.MethodId _enumerate15245;
		public virtual int enumerate(java.lang.ThreadGroup[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.ThreadGroup._enumerate15245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._enumerate15245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _enumerate15246;
		public virtual int enumerate(java.lang.ThreadGroup[] arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.ThreadGroup._enumerate15246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._enumerate15246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _enumerate15247;
		public virtual int enumerate(java.lang.Thread[] arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.ThreadGroup._enumerate15247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._enumerate15247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _enumerate15248;
		public virtual int enumerate(java.lang.Thread[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.ThreadGroup._enumerate15248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._enumerate15248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDaemon15249;
		public virtual bool isDaemon() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.ThreadGroup._isDaemon15249);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._isDaemon15249);
		}
		internal static global::MonoJavaBridge.MethodId _checkAccess15250;
		public virtual void checkAccess() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup._checkAccess15250);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._checkAccess15250);
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
		internal static global::MonoJavaBridge.MethodId _getMaxPriority15251;
		public virtual int getMaxPriority() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.ThreadGroup._getMaxPriority15251);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._getMaxPriority15251);
		}
		internal static global::MonoJavaBridge.MethodId _isDestroyed15252;
		public virtual bool isDestroyed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.ThreadGroup._isDestroyed15252);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._isDestroyed15252);
		}
		internal static global::MonoJavaBridge.MethodId _setMaxPriority15253;
		public virtual void setMaxPriority(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup._setMaxPriority15253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._setMaxPriority15253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parentOf15254;
		public virtual bool parentOf(java.lang.ThreadGroup arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.ThreadGroup._parentOf15254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._parentOf15254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _activeGroupCount15255;
		public virtual int activeGroupCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.ThreadGroup._activeGroupCount15255);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._activeGroupCount15255);
		}
		internal static global::MonoJavaBridge.MethodId _list15256;
		public virtual void list() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup._list15256);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._list15256);
		}
		internal static global::MonoJavaBridge.MethodId _allowThreadSuspension15257;
		public virtual bool allowThreadSuspension(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.ThreadGroup._allowThreadSuspension15257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._allowThreadSuspension15257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ThreadGroup15258;
		public ThreadGroup(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._ThreadGroup15258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ThreadGroup15259;
		public ThreadGroup(java.lang.ThreadGroup arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._ThreadGroup15259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ThreadGroup.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ThreadGroup"));
			global::java.lang.ThreadGroup._uncaughtException15234 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V");
			global::java.lang.ThreadGroup._toString15235 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.ThreadGroup._getName15236 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "getName", "()Ljava/lang/String;");
			global::java.lang.ThreadGroup._getParent15237 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "getParent", "()Ljava/lang/ThreadGroup;");
			global::java.lang.ThreadGroup._setDaemon15238 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "setDaemon", "(Z)V");
			global::java.lang.ThreadGroup._stop15239 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "stop", "()V");
			global::java.lang.ThreadGroup._interrupt15240 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "interrupt", "()V");
			global::java.lang.ThreadGroup._destroy15241 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "destroy", "()V");
			global::java.lang.ThreadGroup._suspend15242 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "suspend", "()V");
			global::java.lang.ThreadGroup._resume15243 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "resume", "()V");
			global::java.lang.ThreadGroup._activeCount15244 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "activeCount", "()I");
			global::java.lang.ThreadGroup._enumerate15245 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/ThreadGroup;)I");
			global::java.lang.ThreadGroup._enumerate15246 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/ThreadGroup;Z)I");
			global::java.lang.ThreadGroup._enumerate15247 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/Thread;Z)I");
			global::java.lang.ThreadGroup._enumerate15248 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/Thread;)I");
			global::java.lang.ThreadGroup._isDaemon15249 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "isDaemon", "()Z");
			global::java.lang.ThreadGroup._checkAccess15250 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "checkAccess", "()V");
			global::java.lang.ThreadGroup._getMaxPriority15251 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "getMaxPriority", "()I");
			global::java.lang.ThreadGroup._isDestroyed15252 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "isDestroyed", "()Z");
			global::java.lang.ThreadGroup._setMaxPriority15253 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "setMaxPriority", "(I)V");
			global::java.lang.ThreadGroup._parentOf15254 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "parentOf", "(Ljava/lang/ThreadGroup;)Z");
			global::java.lang.ThreadGroup._activeGroupCount15255 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "activeGroupCount", "()I");
			global::java.lang.ThreadGroup._list15256 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "list", "()V");
			global::java.lang.ThreadGroup._allowThreadSuspension15257 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "allowThreadSuspension", "(Z)Z");
			global::java.lang.ThreadGroup._ThreadGroup15258 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.ThreadGroup._ThreadGroup15259 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/String;)V");
		}
	}
}
