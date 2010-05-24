namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class MessageQueue : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static MessageQueue() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.MessageQueue), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.os.MessageQueue(@__env); 
			} 
		} 
		protected MessageQueue(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface IdleHandler 
		{ 
			bool queueIdle(); 
		} 

		public partial class IdleHandler_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __IdleHandler.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __IdleHandler : java.lang.Object, IdleHandler
		{ 
			internal static global::java.lang.Class staticClass; 
			static __IdleHandler() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.MessageQueue.__IdleHandler), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.os.MessageQueue.__IdleHandler(@__env); 
				} 
			} 
			internal __IdleHandler(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _queueIdle5676; 
			 bool android.os.MessageQueue.IdleHandler.queueIdle() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.os.MessageQueue.__IdleHandler)) 
					return @__env.CallBooleanMethod(this, _queueIdle5676); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.os.MessageQueue.__IdleHandler.staticClass, _queueIdle5676); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.os.MessageQueue.__IdleHandler.staticClass = @__class; 
				global::android.os.MessageQueue.__IdleHandler._queueIdle5676 = @__env.GetMethodID(global::android.os.MessageQueue.__IdleHandler.staticClass, "android.os.MessageQueue.IdleHandler.queueIdle", "()Z"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addIdleHandler5677; 
		public virtual void addIdleHandler(android.os.MessageQueue.IdleHandler arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.MessageQueue)) 
				@__env.CallVoidMethod(this, _addIdleHandler5677, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.MessageQueue.staticClass, _addIdleHandler5677, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeIdleHandler5678; 
		public virtual void removeIdleHandler(android.os.MessageQueue.IdleHandler arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.MessageQueue)) 
				@__env.CallVoidMethod(this, _removeIdleHandler5678, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.MessageQueue.staticClass, _removeIdleHandler5678, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.MessageQueue.staticClass = @__class; 
			global::android.os.MessageQueue._addIdleHandler5677 = @__env.GetMethodID(global::android.os.MessageQueue.staticClass, "addIdleHandler", "(Landroid/os/MessageQueue$IdleHandler;)V"); 
			global::android.os.MessageQueue._removeIdleHandler5678 = @__env.GetMethodID(global::android.os.MessageQueue.staticClass, "removeIdleHandler", "(Landroid/os/MessageQueue$IdleHandler;)V"); 
		} 
	} 
} 
