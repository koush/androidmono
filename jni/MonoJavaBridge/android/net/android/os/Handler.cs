namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Handler : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Handler() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.Handler), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _toString5319; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString5319)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Handler.staticClass, _toString5319)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dump5320; 
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				@__env.CallVoidMethod(this, _dump5320, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Handler.staticClass, _dump5320, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _handleMessage5321; 
		public virtual void handleMessage(android.os.Message arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				@__env.CallVoidMethod(this, _handleMessage5321, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Handler.staticClass, _handleMessage5321, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchMessage5322; 
		public virtual void dispatchMessage(android.os.Message arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				@__env.CallVoidMethod(this, _dispatchMessage5322, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Handler.staticClass, _dispatchMessage5322, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtainMessage5323; 
		public virtual android.os.Message obtainMessage(int arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallObjectMethodPtr(this, _obtainMessage5323, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Handler.staticClass, _obtainMessage5323, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtainMessage5324; 
		public virtual android.os.Message obtainMessage(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallObjectMethodPtr(this, _obtainMessage5324, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Handler.staticClass, _obtainMessage5324, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtainMessage5325; 
		public virtual android.os.Message obtainMessage(int arg0, int arg1, int arg2, java.lang.Object arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallObjectMethodPtr(this, _obtainMessage5325, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Handler.staticClass, _obtainMessage5325, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtainMessage5326; 
		public virtual android.os.Message obtainMessage(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallObjectMethodPtr(this, _obtainMessage5326, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Handler.staticClass, _obtainMessage5326, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtainMessage5327; 
		public virtual android.os.Message obtainMessage() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallObjectMethodPtr(this, _obtainMessage5327)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Handler.staticClass, _obtainMessage5327)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _post5328; 
		public virtual bool post(java.lang.Runnable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return @__env.CallBooleanMethod(this, _post5328, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.Handler.staticClass, _post5328, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postAtTime5329; 
		public virtual bool postAtTime(java.lang.Runnable arg0, java.lang.Object arg1, long arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return @__env.CallBooleanMethod(this, _postAtTime5329, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.Handler.staticClass, _postAtTime5329, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postAtTime5330; 
		public virtual bool postAtTime(java.lang.Runnable arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return @__env.CallBooleanMethod(this, _postAtTime5330, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.Handler.staticClass, _postAtTime5330, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postDelayed5331; 
		public virtual bool postDelayed(java.lang.Runnable arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return @__env.CallBooleanMethod(this, _postDelayed5331, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.Handler.staticClass, _postDelayed5331, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postAtFrontOfQueue5332; 
		public virtual bool postAtFrontOfQueue(java.lang.Runnable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return @__env.CallBooleanMethod(this, _postAtFrontOfQueue5332, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.Handler.staticClass, _postAtFrontOfQueue5332, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeCallbacks5333; 
		public virtual void removeCallbacks(java.lang.Runnable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				@__env.CallVoidMethod(this, _removeCallbacks5333, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Handler.staticClass, _removeCallbacks5333, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeCallbacks5334; 
		public virtual void removeCallbacks(java.lang.Runnable arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				@__env.CallVoidMethod(this, _removeCallbacks5334, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Handler.staticClass, _removeCallbacks5334, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendMessage5335; 
		public virtual bool sendMessage(android.os.Message arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return @__env.CallBooleanMethod(this, _sendMessage5335, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.Handler.staticClass, _sendMessage5335, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendEmptyMessage5336; 
		public virtual bool sendEmptyMessage(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return @__env.CallBooleanMethod(this, _sendEmptyMessage5336, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.Handler.staticClass, _sendEmptyMessage5336, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendEmptyMessageDelayed5337; 
		public virtual bool sendEmptyMessageDelayed(int arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return @__env.CallBooleanMethod(this, _sendEmptyMessageDelayed5337, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.Handler.staticClass, _sendEmptyMessageDelayed5337, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendEmptyMessageAtTime5338; 
		public virtual bool sendEmptyMessageAtTime(int arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return @__env.CallBooleanMethod(this, _sendEmptyMessageAtTime5338, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.Handler.staticClass, _sendEmptyMessageAtTime5338, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendMessageDelayed5339; 
		public virtual bool sendMessageDelayed(android.os.Message arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return @__env.CallBooleanMethod(this, _sendMessageDelayed5339, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.Handler.staticClass, _sendMessageDelayed5339, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendMessageAtTime5340; 
		public virtual bool sendMessageAtTime(android.os.Message arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return @__env.CallBooleanMethod(this, _sendMessageAtTime5340, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.Handler.staticClass, _sendMessageAtTime5340, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendMessageAtFrontOfQueue5341; 
		public virtual bool sendMessageAtFrontOfQueue(android.os.Message arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return @__env.CallBooleanMethod(this, _sendMessageAtFrontOfQueue5341, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.Handler.staticClass, _sendMessageAtFrontOfQueue5341, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeMessages5342; 
		public virtual void removeMessages(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				@__env.CallVoidMethod(this, _removeMessages5342, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Handler.staticClass, _removeMessages5342, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeMessages5343; 
		public virtual void removeMessages(int arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				@__env.CallVoidMethod(this, _removeMessages5343, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Handler.staticClass, _removeMessages5343, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeCallbacksAndMessages5344; 
		public virtual void removeCallbacksAndMessages(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				@__env.CallVoidMethod(this, _removeCallbacksAndMessages5344, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Handler.staticClass, _removeCallbacksAndMessages5344, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasMessages5345; 
		public virtual bool hasMessages(int arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return @__env.CallBooleanMethod(this, _hasMessages5345, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.Handler.staticClass, _hasMessages5345, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasMessages5346; 
		public virtual bool hasMessages(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return @__env.CallBooleanMethod(this, _hasMessages5346, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.Handler.staticClass, _hasMessages5346, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLooper5347; 
		public virtual android.os.Looper getLooper() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Handler)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Looper>(@__env, @__env.CallObjectMethodPtr(this, _getLooper5347)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Looper>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Handler.staticClass, _getLooper5347)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Handler5348; 
		public Handler()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.Handler.staticClass, _Handler5348, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Handler5349; 
		public Handler(android.os.Handler.Callback arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.Handler.staticClass, _Handler5349, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Handler5350; 
		public Handler(android.os.Looper arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.Handler.staticClass, _Handler5350, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Handler5351; 
		public Handler(android.os.Looper arg0, android.os.Handler.Callback arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.Handler.staticClass, _Handler5351, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.Handler.staticClass = @__class; 
			global::android.os.Handler._toString5319 = @__env.GetMethodID(global::android.os.Handler.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.os.Handler._dump5320 = @__env.GetMethodID(global::android.os.Handler.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V"); 
			global::android.os.Handler._handleMessage5321 = @__env.GetMethodID(global::android.os.Handler.staticClass, "handleMessage", "(Landroid/os/Message;)V"); 
			global::android.os.Handler._dispatchMessage5322 = @__env.GetMethodID(global::android.os.Handler.staticClass, "dispatchMessage", "(Landroid/os/Message;)V"); 
			global::android.os.Handler._obtainMessage5323 = @__env.GetMethodID(global::android.os.Handler.staticClass, "obtainMessage", "(ILjava/lang/Object;)Landroid/os/Message;"); 
			global::android.os.Handler._obtainMessage5324 = @__env.GetMethodID(global::android.os.Handler.staticClass, "obtainMessage", "(III)Landroid/os/Message;"); 
			global::android.os.Handler._obtainMessage5325 = @__env.GetMethodID(global::android.os.Handler.staticClass, "obtainMessage", "(IIILjava/lang/Object;)Landroid/os/Message;"); 
			global::android.os.Handler._obtainMessage5326 = @__env.GetMethodID(global::android.os.Handler.staticClass, "obtainMessage", "(I)Landroid/os/Message;"); 
			global::android.os.Handler._obtainMessage5327 = @__env.GetMethodID(global::android.os.Handler.staticClass, "obtainMessage", "()Landroid/os/Message;"); 
			global::android.os.Handler._post5328 = @__env.GetMethodID(global::android.os.Handler.staticClass, "post", "(Ljava/lang/Runnable;)Z"); 
			global::android.os.Handler._postAtTime5329 = @__env.GetMethodID(global::android.os.Handler.staticClass, "postAtTime", "(Ljava/lang/Runnable;Ljava/lang/Object;J)Z"); 
			global::android.os.Handler._postAtTime5330 = @__env.GetMethodID(global::android.os.Handler.staticClass, "postAtTime", "(Ljava/lang/Runnable;J)Z"); 
			global::android.os.Handler._postDelayed5331 = @__env.GetMethodID(global::android.os.Handler.staticClass, "postDelayed", "(Ljava/lang/Runnable;J)Z"); 
			global::android.os.Handler._postAtFrontOfQueue5332 = @__env.GetMethodID(global::android.os.Handler.staticClass, "postAtFrontOfQueue", "(Ljava/lang/Runnable;)Z"); 
			global::android.os.Handler._removeCallbacks5333 = @__env.GetMethodID(global::android.os.Handler.staticClass, "removeCallbacks", "(Ljava/lang/Runnable;)V"); 
			global::android.os.Handler._removeCallbacks5334 = @__env.GetMethodID(global::android.os.Handler.staticClass, "removeCallbacks", "(Ljava/lang/Runnable;Ljava/lang/Object;)V"); 
			global::android.os.Handler._sendMessage5335 = @__env.GetMethodID(global::android.os.Handler.staticClass, "sendMessage", "(Landroid/os/Message;)Z"); 
			global::android.os.Handler._sendEmptyMessage5336 = @__env.GetMethodID(global::android.os.Handler.staticClass, "sendEmptyMessage", "(I)Z"); 
			global::android.os.Handler._sendEmptyMessageDelayed5337 = @__env.GetMethodID(global::android.os.Handler.staticClass, "sendEmptyMessageDelayed", "(IJ)Z"); 
			global::android.os.Handler._sendEmptyMessageAtTime5338 = @__env.GetMethodID(global::android.os.Handler.staticClass, "sendEmptyMessageAtTime", "(IJ)Z"); 
			global::android.os.Handler._sendMessageDelayed5339 = @__env.GetMethodID(global::android.os.Handler.staticClass, "sendMessageDelayed", "(Landroid/os/Message;J)Z"); 
			global::android.os.Handler._sendMessageAtTime5340 = @__env.GetMethodID(global::android.os.Handler.staticClass, "sendMessageAtTime", "(Landroid/os/Message;J)Z"); 
			global::android.os.Handler._sendMessageAtFrontOfQueue5341 = @__env.GetMethodID(global::android.os.Handler.staticClass, "sendMessageAtFrontOfQueue", "(Landroid/os/Message;)Z"); 
			global::android.os.Handler._removeMessages5342 = @__env.GetMethodID(global::android.os.Handler.staticClass, "removeMessages", "(I)V"); 
			global::android.os.Handler._removeMessages5343 = @__env.GetMethodID(global::android.os.Handler.staticClass, "removeMessages", "(ILjava/lang/Object;)V"); 
			global::android.os.Handler._removeCallbacksAndMessages5344 = @__env.GetMethodID(global::android.os.Handler.staticClass, "removeCallbacksAndMessages", "(Ljava/lang/Object;)V"); 
			global::android.os.Handler._hasMessages5345 = @__env.GetMethodID(global::android.os.Handler.staticClass, "hasMessages", "(ILjava/lang/Object;)Z"); 
			global::android.os.Handler._hasMessages5346 = @__env.GetMethodID(global::android.os.Handler.staticClass, "hasMessages", "(I)Z"); 
			global::android.os.Handler._getLooper5347 = @__env.GetMethodID(global::android.os.Handler.staticClass, "getLooper", "()Landroid/os/Looper;"); 
			global::android.os.Handler._Handler5348 = @__env.GetMethodID(global::android.os.Handler.staticClass, "<init>", "()V"); 
			global::android.os.Handler._Handler5349 = @__env.GetMethodID(global::android.os.Handler.staticClass, "<init>", "(Landroid/os/Handler$Callback;)V"); 
			global::android.os.Handler._Handler5350 = @__env.GetMethodID(global::android.os.Handler.staticClass, "<init>", "(Landroid/os/Looper;)V"); 
			global::android.os.Handler._Handler5351 = @__env.GetMethodID(global::android.os.Handler.staticClass, "<init>", "(Landroid/os/Looper;Landroid/os/Handler$Callback;)V"); 
		} 
	} 
} 
