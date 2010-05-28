namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Handler : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Handler() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.Handler), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.os.Handler(@__env); 
			} 
		} 
		protected Handler(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface Callback 
		{ 
			bool handleMessage(android.os.Message arg0); 
		} 

		public partial class Callback_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __Callback.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __Callback : java.lang.Object, Callback
		{ 
			internal static global::java.lang.Class staticClass; 
			static __Callback() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.Handler.__Callback), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.os.Handler.__Callback(@__env); 
				} 
			} 
			internal __Callback(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _handleMessage5577; 
			 bool android.os.Handler.Callback.handleMessage(android.os.Message arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.os.Handler.__Callback)) 
					return @__env.CallBooleanMethod(this, global::android.os.Handler.__Callback._handleMessage5577, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Handler.__Callback.staticClass, global::android.os.Handler.__Callback._handleMessage5577, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.os.Handler.__Callback.staticClass = @__class; 
				global::android.os.Handler.__Callback._handleMessage5577 = @__env.GetMethodID(global::android.os.Handler.__Callback.staticClass, "android.os.Handler.Callback.handleMessage", "(Landroid/os/Message;)Z"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString5578; 
		public override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Handler._toString5578)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Handler.staticClass, global::android.os.Handler._toString5578)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dump5579; 
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				@__env.CallVoidMethod(this, global::android.os.Handler._dump5579, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._dump5579, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _handleMessage5580; 
		public virtual void handleMessage(android.os.Message arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				@__env.CallVoidMethod(this, global::android.os.Handler._handleMessage5580, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._handleMessage5580, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchMessage5581; 
		public virtual void dispatchMessage(android.os.Message arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				@__env.CallVoidMethod(this, global::android.os.Handler._dispatchMessage5581, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._dispatchMessage5581, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtainMessage5582; 
		public virtual global::android.os.Message obtainMessage(int arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Handler._obtainMessage5582, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Handler.staticClass, global::android.os.Handler._obtainMessage5582, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtainMessage5583; 
		public virtual global::android.os.Message obtainMessage(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Handler._obtainMessage5583, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Handler.staticClass, global::android.os.Handler._obtainMessage5583, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtainMessage5584; 
		public virtual global::android.os.Message obtainMessage(int arg0, int arg1, int arg2, java.lang.Object arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Handler._obtainMessage5584, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Handler.staticClass, global::android.os.Handler._obtainMessage5584, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtainMessage5585; 
		public virtual global::android.os.Message obtainMessage(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Handler._obtainMessage5585, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Handler.staticClass, global::android.os.Handler._obtainMessage5585, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtainMessage5586; 
		public virtual global::android.os.Message obtainMessage() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Handler._obtainMessage5586)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Handler.staticClass, global::android.os.Handler._obtainMessage5586)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _post5587; 
		public virtual bool post(java.lang.Runnable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return @__env.CallBooleanMethod(this, global::android.os.Handler._post5587, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._post5587, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postAtTime5588; 
		public virtual bool postAtTime(java.lang.Runnable arg0, java.lang.Object arg1, long arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return @__env.CallBooleanMethod(this, global::android.os.Handler._postAtTime5588, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._postAtTime5588, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postAtTime5589; 
		public virtual bool postAtTime(java.lang.Runnable arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return @__env.CallBooleanMethod(this, global::android.os.Handler._postAtTime5589, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._postAtTime5589, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postDelayed5590; 
		public virtual bool postDelayed(java.lang.Runnable arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return @__env.CallBooleanMethod(this, global::android.os.Handler._postDelayed5590, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._postDelayed5590, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postAtFrontOfQueue5591; 
		public virtual bool postAtFrontOfQueue(java.lang.Runnable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return @__env.CallBooleanMethod(this, global::android.os.Handler._postAtFrontOfQueue5591, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._postAtFrontOfQueue5591, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeCallbacks5592; 
		public virtual void removeCallbacks(java.lang.Runnable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				@__env.CallVoidMethod(this, global::android.os.Handler._removeCallbacks5592, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._removeCallbacks5592, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeCallbacks5593; 
		public virtual void removeCallbacks(java.lang.Runnable arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				@__env.CallVoidMethod(this, global::android.os.Handler._removeCallbacks5593, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._removeCallbacks5593, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendMessage5594; 
		public virtual bool sendMessage(android.os.Message arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return @__env.CallBooleanMethod(this, global::android.os.Handler._sendMessage5594, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._sendMessage5594, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendEmptyMessage5595; 
		public virtual bool sendEmptyMessage(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return @__env.CallBooleanMethod(this, global::android.os.Handler._sendEmptyMessage5595, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._sendEmptyMessage5595, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendEmptyMessageDelayed5596; 
		public virtual bool sendEmptyMessageDelayed(int arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return @__env.CallBooleanMethod(this, global::android.os.Handler._sendEmptyMessageDelayed5596, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._sendEmptyMessageDelayed5596, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendEmptyMessageAtTime5597; 
		public virtual bool sendEmptyMessageAtTime(int arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return @__env.CallBooleanMethod(this, global::android.os.Handler._sendEmptyMessageAtTime5597, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._sendEmptyMessageAtTime5597, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendMessageDelayed5598; 
		public virtual bool sendMessageDelayed(android.os.Message arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return @__env.CallBooleanMethod(this, global::android.os.Handler._sendMessageDelayed5598, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._sendMessageDelayed5598, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendMessageAtTime5599; 
		public virtual bool sendMessageAtTime(android.os.Message arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return @__env.CallBooleanMethod(this, global::android.os.Handler._sendMessageAtTime5599, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._sendMessageAtTime5599, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendMessageAtFrontOfQueue5600; 
		public virtual bool sendMessageAtFrontOfQueue(android.os.Message arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return @__env.CallBooleanMethod(this, global::android.os.Handler._sendMessageAtFrontOfQueue5600, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._sendMessageAtFrontOfQueue5600, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeMessages5601; 
		public virtual void removeMessages(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				@__env.CallVoidMethod(this, global::android.os.Handler._removeMessages5601, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._removeMessages5601, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeMessages5602; 
		public virtual void removeMessages(int arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				@__env.CallVoidMethod(this, global::android.os.Handler._removeMessages5602, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._removeMessages5602, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeCallbacksAndMessages5603; 
		public virtual void removeCallbacksAndMessages(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				@__env.CallVoidMethod(this, global::android.os.Handler._removeCallbacksAndMessages5603, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._removeCallbacksAndMessages5603, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasMessages5604; 
		public virtual bool hasMessages(int arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return @__env.CallBooleanMethod(this, global::android.os.Handler._hasMessages5604, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._hasMessages5604, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasMessages5605; 
		public virtual bool hasMessages(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return @__env.CallBooleanMethod(this, global::android.os.Handler._hasMessages5605, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._hasMessages5605, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLooper5606; 
		public virtual global::android.os.Looper getLooper() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Looper>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Handler._getLooper5606)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Looper>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Handler.staticClass, global::android.os.Handler._getLooper5606)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Handler5607; 
		public Handler()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.Handler.staticClass, global::android.os.Handler._Handler5607, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Handler5608; 
		public Handler(android.os.Handler.Callback arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.Handler.staticClass, global::android.os.Handler._Handler5608, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Handler5609; 
		public Handler(android.os.Looper arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.Handler.staticClass, global::android.os.Handler._Handler5609, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Handler5610; 
		public Handler(android.os.Looper arg0, android.os.Handler.Callback arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.Handler.staticClass, global::android.os.Handler._Handler5610, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.Handler.staticClass = @__class; 
			global::android.os.Handler._toString5578 = @__env.GetMethodID(global::android.os.Handler.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.os.Handler._dump5579 = @__env.GetMethodID(global::android.os.Handler.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V"); 
			global::android.os.Handler._handleMessage5580 = @__env.GetMethodID(global::android.os.Handler.staticClass, "handleMessage", "(Landroid/os/Message;)V"); 
			global::android.os.Handler._dispatchMessage5581 = @__env.GetMethodID(global::android.os.Handler.staticClass, "dispatchMessage", "(Landroid/os/Message;)V"); 
			global::android.os.Handler._obtainMessage5582 = @__env.GetMethodID(global::android.os.Handler.staticClass, "obtainMessage", "(ILjava/lang/Object;)Landroid/os/Message;"); 
			global::android.os.Handler._obtainMessage5583 = @__env.GetMethodID(global::android.os.Handler.staticClass, "obtainMessage", "(III)Landroid/os/Message;"); 
			global::android.os.Handler._obtainMessage5584 = @__env.GetMethodID(global::android.os.Handler.staticClass, "obtainMessage", "(IIILjava/lang/Object;)Landroid/os/Message;"); 
			global::android.os.Handler._obtainMessage5585 = @__env.GetMethodID(global::android.os.Handler.staticClass, "obtainMessage", "(I)Landroid/os/Message;"); 
			global::android.os.Handler._obtainMessage5586 = @__env.GetMethodID(global::android.os.Handler.staticClass, "obtainMessage", "()Landroid/os/Message;"); 
			global::android.os.Handler._post5587 = @__env.GetMethodID(global::android.os.Handler.staticClass, "post", "(Ljava/lang/Runnable;)Z"); 
			global::android.os.Handler._postAtTime5588 = @__env.GetMethodID(global::android.os.Handler.staticClass, "postAtTime", "(Ljava/lang/Runnable;Ljava/lang/Object;J)Z"); 
			global::android.os.Handler._postAtTime5589 = @__env.GetMethodID(global::android.os.Handler.staticClass, "postAtTime", "(Ljava/lang/Runnable;J)Z"); 
			global::android.os.Handler._postDelayed5590 = @__env.GetMethodID(global::android.os.Handler.staticClass, "postDelayed", "(Ljava/lang/Runnable;J)Z"); 
			global::android.os.Handler._postAtFrontOfQueue5591 = @__env.GetMethodID(global::android.os.Handler.staticClass, "postAtFrontOfQueue", "(Ljava/lang/Runnable;)Z"); 
			global::android.os.Handler._removeCallbacks5592 = @__env.GetMethodID(global::android.os.Handler.staticClass, "removeCallbacks", "(Ljava/lang/Runnable;)V"); 
			global::android.os.Handler._removeCallbacks5593 = @__env.GetMethodID(global::android.os.Handler.staticClass, "removeCallbacks", "(Ljava/lang/Runnable;Ljava/lang/Object;)V"); 
			global::android.os.Handler._sendMessage5594 = @__env.GetMethodID(global::android.os.Handler.staticClass, "sendMessage", "(Landroid/os/Message;)Z"); 
			global::android.os.Handler._sendEmptyMessage5595 = @__env.GetMethodID(global::android.os.Handler.staticClass, "sendEmptyMessage", "(I)Z"); 
			global::android.os.Handler._sendEmptyMessageDelayed5596 = @__env.GetMethodID(global::android.os.Handler.staticClass, "sendEmptyMessageDelayed", "(IJ)Z"); 
			global::android.os.Handler._sendEmptyMessageAtTime5597 = @__env.GetMethodID(global::android.os.Handler.staticClass, "sendEmptyMessageAtTime", "(IJ)Z"); 
			global::android.os.Handler._sendMessageDelayed5598 = @__env.GetMethodID(global::android.os.Handler.staticClass, "sendMessageDelayed", "(Landroid/os/Message;J)Z"); 
			global::android.os.Handler._sendMessageAtTime5599 = @__env.GetMethodID(global::android.os.Handler.staticClass, "sendMessageAtTime", "(Landroid/os/Message;J)Z"); 
			global::android.os.Handler._sendMessageAtFrontOfQueue5600 = @__env.GetMethodID(global::android.os.Handler.staticClass, "sendMessageAtFrontOfQueue", "(Landroid/os/Message;)Z"); 
			global::android.os.Handler._removeMessages5601 = @__env.GetMethodID(global::android.os.Handler.staticClass, "removeMessages", "(I)V"); 
			global::android.os.Handler._removeMessages5602 = @__env.GetMethodID(global::android.os.Handler.staticClass, "removeMessages", "(ILjava/lang/Object;)V"); 
			global::android.os.Handler._removeCallbacksAndMessages5603 = @__env.GetMethodID(global::android.os.Handler.staticClass, "removeCallbacksAndMessages", "(Ljava/lang/Object;)V"); 
			global::android.os.Handler._hasMessages5604 = @__env.GetMethodID(global::android.os.Handler.staticClass, "hasMessages", "(ILjava/lang/Object;)Z"); 
			global::android.os.Handler._hasMessages5605 = @__env.GetMethodID(global::android.os.Handler.staticClass, "hasMessages", "(I)Z"); 
			global::android.os.Handler._getLooper5606 = @__env.GetMethodID(global::android.os.Handler.staticClass, "getLooper", "()Landroid/os/Looper;"); 
			global::android.os.Handler._Handler5607 = @__env.GetMethodID(global::android.os.Handler.staticClass, "<init>", "()V"); 
			global::android.os.Handler._Handler5608 = @__env.GetMethodID(global::android.os.Handler.staticClass, "<init>", "(Landroid/os/Handler$Callback;)V"); 
			global::android.os.Handler._Handler5609 = @__env.GetMethodID(global::android.os.Handler.staticClass, "<init>", "(Landroid/os/Looper;)V"); 
			global::android.os.Handler._Handler5610 = @__env.GetMethodID(global::android.os.Handler.staticClass, "<init>", "(Landroid/os/Looper;Landroid/os/Handler$Callback;)V"); 
		} 
	} 
} 
