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
		internal static global::net.sf.jni4net.jni.MethodId _uncaughtException10742; 
		public virtual void uncaughtException(java.lang.Thread arg0, java.lang.Throwable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				@__env.CallVoidMethod(this, _uncaughtException10742, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.ThreadGroup.staticClass, _uncaughtException10742, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString10743; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString10743)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.lang.ThreadGroup.staticClass, _toString10743)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getName10744; 
		public virtual java.lang.String getName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getName10744)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.lang.ThreadGroup.staticClass, _getName10744)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getParent10745; 
		public virtual java.lang.ThreadGroup getParent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.ThreadGroup>(@__env, @__env.CallObjectMethodPtr(this, _getParent10745)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.ThreadGroup>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.lang.ThreadGroup.staticClass, _getParent10745)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDaemon10746; 
		public virtual void setDaemon(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				@__env.CallVoidMethod(this, _setDaemon10746, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.ThreadGroup.staticClass, _setDaemon10746, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stop10747; 
		public virtual void stop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				@__env.CallVoidMethod(this, _stop10747); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.ThreadGroup.staticClass, _stop10747); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _interrupt10748; 
		public virtual void interrupt() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				@__env.CallVoidMethod(this, _interrupt10748); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.ThreadGroup.staticClass, _interrupt10748); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _destroy10749; 
		public virtual void destroy() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				@__env.CallVoidMethod(this, _destroy10749); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.ThreadGroup.staticClass, _destroy10749); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _suspend10750; 
		public virtual void suspend() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				@__env.CallVoidMethod(this, _suspend10750); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.ThreadGroup.staticClass, _suspend10750); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resume10751; 
		public virtual void resume() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				@__env.CallVoidMethod(this, _resume10751); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.ThreadGroup.staticClass, _resume10751); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _activeCount10752; 
		public virtual int activeCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				return @__env.CallIntMethod(this, _activeCount10752); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.lang.ThreadGroup.staticClass, _activeCount10752); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _enumerate10753; 
		public virtual int enumerate(java.lang.Thread[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				return @__env.CallIntMethod(this, _enumerate10753, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.lang.ThreadGroup.staticClass, _enumerate10753, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _enumerate10754; 
		public virtual int enumerate(java.lang.Thread[] arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				return @__env.CallIntMethod(this, _enumerate10754, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.lang.ThreadGroup.staticClass, _enumerate10754, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _enumerate10755; 
		public virtual int enumerate(java.lang.ThreadGroup[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				return @__env.CallIntMethod(this, _enumerate10755, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.lang.ThreadGroup.staticClass, _enumerate10755, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _enumerate10756; 
		public virtual int enumerate(java.lang.ThreadGroup[] arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				return @__env.CallIntMethod(this, _enumerate10756, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.lang.ThreadGroup.staticClass, _enumerate10756, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isDaemon10757; 
		public virtual bool isDaemon() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				return @__env.CallBooleanMethod(this, _isDaemon10757); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.lang.ThreadGroup.staticClass, _isDaemon10757); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkAccess10758; 
		public virtual void checkAccess() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				@__env.CallVoidMethod(this, _checkAccess10758); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.ThreadGroup.staticClass, _checkAccess10758); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaxPriority10759; 
		public virtual int getMaxPriority() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				return @__env.CallIntMethod(this, _getMaxPriority10759); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.lang.ThreadGroup.staticClass, _getMaxPriority10759); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isDestroyed10760; 
		public virtual bool isDestroyed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				return @__env.CallBooleanMethod(this, _isDestroyed10760); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.lang.ThreadGroup.staticClass, _isDestroyed10760); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMaxPriority10761; 
		public virtual void setMaxPriority(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				@__env.CallVoidMethod(this, _setMaxPriority10761, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.ThreadGroup.staticClass, _setMaxPriority10761, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _parentOf10762; 
		public virtual bool parentOf(java.lang.ThreadGroup arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				return @__env.CallBooleanMethod(this, _parentOf10762, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.lang.ThreadGroup.staticClass, _parentOf10762, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _activeGroupCount10763; 
		public virtual int activeGroupCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				return @__env.CallIntMethod(this, _activeGroupCount10763); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.lang.ThreadGroup.staticClass, _activeGroupCount10763); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _list10764; 
		public virtual void list() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				@__env.CallVoidMethod(this, _list10764); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.ThreadGroup.staticClass, _list10764); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _allowThreadSuspension10765; 
		public virtual bool allowThreadSuspension(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.ThreadGroup)) 
				return @__env.CallBooleanMethod(this, _allowThreadSuspension10765, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.lang.ThreadGroup.staticClass, _allowThreadSuspension10765, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ThreadGroup10766; 
		public ThreadGroup(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.lang.ThreadGroup.staticClass, _ThreadGroup10766, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ThreadGroup10767; 
		public ThreadGroup(java.lang.ThreadGroup arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.lang.ThreadGroup.staticClass, _ThreadGroup10767, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.lang.ThreadGroup.staticClass = @__class; 
			global::java.lang.ThreadGroup._uncaughtException10742 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V"); 
			global::java.lang.ThreadGroup._toString10743 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.lang.ThreadGroup._getName10744 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "getName", "()Ljava/lang/String;"); 
			global::java.lang.ThreadGroup._getParent10745 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "getParent", "()Ljava/lang/ThreadGroup;"); 
			global::java.lang.ThreadGroup._setDaemon10746 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "setDaemon", "(Z)V"); 
			global::java.lang.ThreadGroup._stop10747 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "stop", "()V"); 
			global::java.lang.ThreadGroup._interrupt10748 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "interrupt", "()V"); 
			global::java.lang.ThreadGroup._destroy10749 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "destroy", "()V"); 
			global::java.lang.ThreadGroup._suspend10750 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "suspend", "()V"); 
			global::java.lang.ThreadGroup._resume10751 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "resume", "()V"); 
			global::java.lang.ThreadGroup._activeCount10752 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "activeCount", "()I"); 
			global::java.lang.ThreadGroup._enumerate10753 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/Thread;)I"); 
			global::java.lang.ThreadGroup._enumerate10754 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/Thread;Z)I"); 
			global::java.lang.ThreadGroup._enumerate10755 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/ThreadGroup;)I"); 
			global::java.lang.ThreadGroup._enumerate10756 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/ThreadGroup;Z)I"); 
			global::java.lang.ThreadGroup._isDaemon10757 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "isDaemon", "()Z"); 
			global::java.lang.ThreadGroup._checkAccess10758 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "checkAccess", "()V"); 
			global::java.lang.ThreadGroup._getMaxPriority10759 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "getMaxPriority", "()I"); 
			global::java.lang.ThreadGroup._isDestroyed10760 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "isDestroyed", "()Z"); 
			global::java.lang.ThreadGroup._setMaxPriority10761 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "setMaxPriority", "(I)V"); 
			global::java.lang.ThreadGroup._parentOf10762 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "parentOf", "(Ljava/lang/ThreadGroup;)Z"); 
			global::java.lang.ThreadGroup._activeGroupCount10763 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "activeGroupCount", "()I"); 
			global::java.lang.ThreadGroup._list10764 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "list", "()V"); 
			global::java.lang.ThreadGroup._allowThreadSuspension10765 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "allowThreadSuspension", "(Z)Z"); 
			global::java.lang.ThreadGroup._ThreadGroup10766 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			global::java.lang.ThreadGroup._ThreadGroup10767 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/String;)V"); 
		} 
	} 
} 
