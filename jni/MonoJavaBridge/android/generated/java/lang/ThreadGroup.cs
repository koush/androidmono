namespace java.lang
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ThreadGroup : java.lang.Object, java.lang.Thread.UncaughtExceptionHandler
	{
		internal static global::java.lang.Class staticClass;
		static ThreadGroup()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.lang.ThreadGroup), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
		internal static global::net.sf.jni4net.jni.MethodId _uncaughtException12296;
		public virtual void uncaughtException(java.lang.Thread arg0, java.lang.Throwable arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.ThreadGroup._uncaughtException12296, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._uncaughtException12296, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString12297;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.ThreadGroup._toString12297));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._toString12297));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getName12298;
		public virtual global::java.lang.String getName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.ThreadGroup._getName12298));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._getName12298));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParent12299;
		public virtual global::java.lang.ThreadGroup getParent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.ThreadGroup>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.ThreadGroup._getParent12299));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.ThreadGroup>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._getParent12299));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDaemon12300;
		public virtual void setDaemon(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.ThreadGroup._setDaemon12300, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._setDaemon12300, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _stop12301;
		public virtual void stop() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.ThreadGroup._stop12301);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._stop12301);
		}
		internal static global::net.sf.jni4net.jni.MethodId _interrupt12302;
		public virtual void interrupt() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.ThreadGroup._interrupt12302);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._interrupt12302);
		}
		internal static global::net.sf.jni4net.jni.MethodId _destroy12303;
		public virtual void destroy() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.ThreadGroup._destroy12303);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._destroy12303);
		}
		internal static global::net.sf.jni4net.jni.MethodId _suspend12304;
		public virtual void suspend() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.ThreadGroup._suspend12304);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._suspend12304);
		}
		internal static global::net.sf.jni4net.jni.MethodId _resume12305;
		public virtual void resume() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.ThreadGroup._resume12305);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._resume12305);
		}
		internal static global::net.sf.jni4net.jni.MethodId _activeCount12306;
		public virtual int activeCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.lang.ThreadGroup._activeCount12306);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._activeCount12306);
		}
		internal static global::net.sf.jni4net.jni.MethodId _enumerate12307;
		public virtual int enumerate(java.lang.ThreadGroup[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.lang.ThreadGroup._enumerate12307, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._enumerate12307, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _enumerate12308;
		public virtual int enumerate(java.lang.ThreadGroup[] arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.lang.ThreadGroup._enumerate12308, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._enumerate12308, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _enumerate12309;
		public virtual int enumerate(java.lang.Thread[] arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.lang.ThreadGroup._enumerate12309, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._enumerate12309, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _enumerate12310;
		public virtual int enumerate(java.lang.Thread[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.lang.ThreadGroup._enumerate12310, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._enumerate12310, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isDaemon12311;
		public virtual bool isDaemon() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.lang.ThreadGroup._isDaemon12311);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._isDaemon12311);
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkAccess12312;
		public virtual void checkAccess() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.ThreadGroup._checkAccess12312);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._checkAccess12312);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMaxPriority12313;
		public virtual int getMaxPriority() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.lang.ThreadGroup._getMaxPriority12313);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._getMaxPriority12313);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isDestroyed12314;
		public virtual bool isDestroyed() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.lang.ThreadGroup._isDestroyed12314);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._isDestroyed12314);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMaxPriority12315;
		public virtual void setMaxPriority(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.ThreadGroup._setMaxPriority12315, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._setMaxPriority12315, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _parentOf12316;
		public virtual bool parentOf(java.lang.ThreadGroup arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.lang.ThreadGroup._parentOf12316, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._parentOf12316, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _activeGroupCount12317;
		public virtual int activeGroupCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.lang.ThreadGroup._activeGroupCount12317);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._activeGroupCount12317);
		}
		internal static global::net.sf.jni4net.jni.MethodId _list12318;
		public virtual void list() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.ThreadGroup._list12318);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._list12318);
		}
		internal static global::net.sf.jni4net.jni.MethodId _allowThreadSuspension12319;
		public virtual bool allowThreadSuspension(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.lang.ThreadGroup._allowThreadSuspension12319, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._allowThreadSuspension12319, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ThreadGroup12320;
		public ThreadGroup(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._ThreadGroup12320, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ThreadGroup12321;
		public ThreadGroup(java.lang.ThreadGroup arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._ThreadGroup12321, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.lang.ThreadGroup.staticClass = @__class;
			global::java.lang.ThreadGroup._uncaughtException12296 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V");
			global::java.lang.ThreadGroup._toString12297 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.ThreadGroup._getName12298 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "getName", "()Ljava/lang/String;");
			global::java.lang.ThreadGroup._getParent12299 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "getParent", "()Ljava/lang/ThreadGroup;");
			global::java.lang.ThreadGroup._setDaemon12300 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "setDaemon", "(Z)V");
			global::java.lang.ThreadGroup._stop12301 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "stop", "()V");
			global::java.lang.ThreadGroup._interrupt12302 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "interrupt", "()V");
			global::java.lang.ThreadGroup._destroy12303 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "destroy", "()V");
			global::java.lang.ThreadGroup._suspend12304 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "suspend", "()V");
			global::java.lang.ThreadGroup._resume12305 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "resume", "()V");
			global::java.lang.ThreadGroup._activeCount12306 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "activeCount", "()I");
			global::java.lang.ThreadGroup._enumerate12307 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/ThreadGroup;)I");
			global::java.lang.ThreadGroup._enumerate12308 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/ThreadGroup;Z)I");
			global::java.lang.ThreadGroup._enumerate12309 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/Thread;Z)I");
			global::java.lang.ThreadGroup._enumerate12310 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/Thread;)I");
			global::java.lang.ThreadGroup._isDaemon12311 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "isDaemon", "()Z");
			global::java.lang.ThreadGroup._checkAccess12312 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "checkAccess", "()V");
			global::java.lang.ThreadGroup._getMaxPriority12313 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "getMaxPriority", "()I");
			global::java.lang.ThreadGroup._isDestroyed12314 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "isDestroyed", "()Z");
			global::java.lang.ThreadGroup._setMaxPriority12315 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "setMaxPriority", "(I)V");
			global::java.lang.ThreadGroup._parentOf12316 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "parentOf", "(Ljava/lang/ThreadGroup;)Z");
			global::java.lang.ThreadGroup._activeGroupCount12317 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "activeGroupCount", "()I");
			global::java.lang.ThreadGroup._list12318 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "list", "()V");
			global::java.lang.ThreadGroup._allowThreadSuspension12319 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "allowThreadSuspension", "(Z)Z");
			global::java.lang.ThreadGroup._ThreadGroup12320 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.ThreadGroup._ThreadGroup12321 = @__env.GetMethodID(global::java.lang.ThreadGroup.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/String;)V");
		}
	}
}
