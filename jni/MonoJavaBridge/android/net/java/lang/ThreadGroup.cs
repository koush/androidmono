namespace java.lang 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ThreadGroup : java.lang.Object, java.lang.Thread.UncaughtExceptionHandler
	{ 
		internal static global::java.lang.Class staticClass; 
		static ThreadGroup() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.lang.ThreadGroup), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.lang.ThreadGroup(@__env); 
			} 
		} 
		protected ThreadGroup(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _uncaughtException11567; 
		public virtual void uncaughtException(java.lang.Thread arg0, java.lang.Throwable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				@__env.CallVoidMethod(this, _uncaughtException11567, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.ThreadGroup.staticClass, _uncaughtException11567, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11568; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11568)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.lang.ThreadGroup.staticClass, _toString11568)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getName11569; 
		public virtual java.lang.String getName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getName11569)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.lang.ThreadGroup.staticClass, _getName11569)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getParent11570; 
		public virtual java.lang.ThreadGroup getParent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.ThreadGroup>(@__env, @__env.CallObjectMethodPtr(this, _getParent11570)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.ThreadGroup>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.lang.ThreadGroup.staticClass, _getParent11570)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDaemon11571; 
		public virtual void setDaemon(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				@__env.CallVoidMethod(this, _setDaemon11571, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.ThreadGroup.staticClass, _setDaemon11571, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stop11572; 
		public virtual void stop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				@__env.CallVoidMethod(this, _stop11572); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.ThreadGroup.staticClass, _stop11572); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _interrupt11573; 
		public virtual void interrupt() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				@__env.CallVoidMethod(this, _interrupt11573); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.ThreadGroup.staticClass, _interrupt11573); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _destroy11574; 
		public virtual void destroy() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				@__env.CallVoidMethod(this, _destroy11574); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.ThreadGroup.staticClass, _destroy11574); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _suspend11575; 
		public virtual void suspend() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				@__env.CallVoidMethod(this, _suspend11575); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.ThreadGroup.staticClass, _suspend11575); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resume11576; 
		public virtual void resume() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				@__env.CallVoidMethod(this, _resume11576); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.ThreadGroup.staticClass, _resume11576); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _activeCount11577; 
		public virtual int activeCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				return @__env.CallIntMethod(this, _activeCount11577); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.lang.ThreadGroup.staticClass, _activeCount11577); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _enumerate11578; 
		public virtual int enumerate(java.lang.Thread[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				return @__env.CallIntMethod(this, _enumerate11578, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.lang.ThreadGroup.staticClass, _enumerate11578, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _enumerate11579; 
		public virtual int enumerate(java.lang.Thread[] arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				return @__env.CallIntMethod(this, _enumerate11579, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.lang.ThreadGroup.staticClass, _enumerate11579, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _enumerate11580; 
		public virtual int enumerate(java.lang.ThreadGroup[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				return @__env.CallIntMethod(this, _enumerate11580, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.lang.ThreadGroup.staticClass, _enumerate11580, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _enumerate11581; 
		public virtual int enumerate(java.lang.ThreadGroup[] arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				return @__env.CallIntMethod(this, _enumerate11581, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.lang.ThreadGroup.staticClass, _enumerate11581, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isDaemon11582; 
		public virtual bool isDaemon() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				return @__env.CallBooleanMethod(this, _isDaemon11582); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.lang.ThreadGroup.staticClass, _isDaemon11582); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkAccess11583; 
		public virtual void checkAccess() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				@__env.CallVoidMethod(this, _checkAccess11583); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.ThreadGroup.staticClass, _checkAccess11583); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaxPriority11584; 
		public virtual int getMaxPriority() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				return @__env.CallIntMethod(this, _getMaxPriority11584); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.lang.ThreadGroup.staticClass, _getMaxPriority11584); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isDestroyed11585; 
		public virtual bool isDestroyed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				return @__env.CallBooleanMethod(this, _isDestroyed11585); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.lang.ThreadGroup.staticClass, _isDestroyed11585); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMaxPriority11586; 
		public virtual void setMaxPriority(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				@__env.CallVoidMethod(this, _setMaxPriority11586, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.ThreadGroup.staticClass, _setMaxPriority11586, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _parentOf11587; 
		public virtual bool parentOf(java.lang.ThreadGroup arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				return @__env.CallBooleanMethod(this, _parentOf11587, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.lang.ThreadGroup.staticClass, _parentOf11587, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _activeGroupCount11588; 
		public virtual int activeGroupCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				return @__env.CallIntMethod(this, _activeGroupCount11588); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.lang.ThreadGroup.staticClass, _activeGroupCount11588); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _list11589; 
		public virtual void list() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				@__env.CallVoidMethod(this, _list11589); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.ThreadGroup.staticClass, _list11589); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _allowThreadSuspension11590; 
		public virtual bool allowThreadSuspension(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				return @__env.CallBooleanMethod(this, _allowThreadSuspension11590, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.lang.ThreadGroup.staticClass, _allowThreadSuspension11590, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ThreadGroup11591; 
		public ThreadGroup(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.lang.ThreadGroup.staticClass, _ThreadGroup11591, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ThreadGroup11592; 
		public ThreadGroup(java.lang.ThreadGroup arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.lang.ThreadGroup.staticClass, _ThreadGroup11592, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.lang.ThreadGroup.staticClass = @__class; 
			global::java.lang.ThreadGroup._uncaughtException11567 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V"); 
			global::java.lang.ThreadGroup._toString11568 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.lang.ThreadGroup._getName11569 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "getName", "()Ljava/lang/String;"); 
			global::java.lang.ThreadGroup._getParent11570 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "getParent", "()Ljava/lang/ThreadGroup;"); 
			global::java.lang.ThreadGroup._setDaemon11571 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "setDaemon", "(Z)V"); 
			global::java.lang.ThreadGroup._stop11572 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "stop", "()V"); 
			global::java.lang.ThreadGroup._interrupt11573 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "interrupt", "()V"); 
			global::java.lang.ThreadGroup._destroy11574 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "destroy", "()V"); 
			global::java.lang.ThreadGroup._suspend11575 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "suspend", "()V"); 
			global::java.lang.ThreadGroup._resume11576 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "resume", "()V"); 
			global::java.lang.ThreadGroup._activeCount11577 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "activeCount", "()I"); 
			global::java.lang.ThreadGroup._enumerate11578 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/Thread;)I"); 
			global::java.lang.ThreadGroup._enumerate11579 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/Thread;Z)I"); 
			global::java.lang.ThreadGroup._enumerate11580 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/ThreadGroup;)I"); 
			global::java.lang.ThreadGroup._enumerate11581 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/ThreadGroup;Z)I"); 
			global::java.lang.ThreadGroup._isDaemon11582 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "isDaemon", "()Z"); 
			global::java.lang.ThreadGroup._checkAccess11583 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "checkAccess", "()V"); 
			global::java.lang.ThreadGroup._getMaxPriority11584 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "getMaxPriority", "()I"); 
			global::java.lang.ThreadGroup._isDestroyed11585 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "isDestroyed", "()Z"); 
			global::java.lang.ThreadGroup._setMaxPriority11586 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "setMaxPriority", "(I)V"); 
			global::java.lang.ThreadGroup._parentOf11587 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "parentOf", "(Ljava/lang/ThreadGroup;)Z"); 
			global::java.lang.ThreadGroup._activeGroupCount11588 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "activeGroupCount", "()I"); 
			global::java.lang.ThreadGroup._list11589 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "list", "()V"); 
			global::java.lang.ThreadGroup._allowThreadSuspension11590 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "allowThreadSuspension", "(Z)Z"); 
			global::java.lang.ThreadGroup._ThreadGroup11591 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			global::java.lang.ThreadGroup._ThreadGroup11592 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/String;)V"); 
		} 
	} 
} 
