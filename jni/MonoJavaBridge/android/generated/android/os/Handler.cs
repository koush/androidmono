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
			internal static global::net.sf.jni4net.jni.MethodId _handleMessage6150;
			 bool android.os.Handler.Callback.handleMessage(android.os.Message arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.os.Handler.__Callback._handleMessage6150, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Handler.__Callback.staticClass, global::android.os.Handler.__Callback._handleMessage6150, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.os.Handler.__Callback.staticClass = @__class;
				global::android.os.Handler.__Callback._handleMessage6150 = @__env.GetMethodID(global::android.os.Handler.__Callback.staticClass, "android.os.Handler.Callback.handleMessage", "(Landroid/os/Message;)Z");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString6151;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Handler._toString6151));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Handler.staticClass, global::android.os.Handler._toString6151));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dump6152;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Handler._dump6152, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._dump6152, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _handleMessage6153;
		public virtual void handleMessage(android.os.Message arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Handler._handleMessage6153, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._handleMessage6153, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchMessage6154;
		public virtual void dispatchMessage(android.os.Message arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Handler._dispatchMessage6154, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._dispatchMessage6154, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _obtainMessage6155;
		public virtual global::android.os.Message obtainMessage(int arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Handler._obtainMessage6155, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Handler.staticClass, global::android.os.Handler._obtainMessage6155, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _obtainMessage6156;
		public virtual global::android.os.Message obtainMessage(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Handler._obtainMessage6156, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Handler.staticClass, global::android.os.Handler._obtainMessage6156, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _obtainMessage6157;
		public virtual global::android.os.Message obtainMessage(int arg0, int arg1, int arg2, java.lang.Object arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Handler._obtainMessage6157, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Handler.staticClass, global::android.os.Handler._obtainMessage6157, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _obtainMessage6158;
		public virtual global::android.os.Message obtainMessage(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Handler._obtainMessage6158, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Handler.staticClass, global::android.os.Handler._obtainMessage6158, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _obtainMessage6159;
		public virtual global::android.os.Message obtainMessage() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Handler._obtainMessage6159));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Message>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Handler.staticClass, global::android.os.Handler._obtainMessage6159));
		}
		internal static global::net.sf.jni4net.jni.MethodId _post6160;
		public virtual bool post(java.lang.Runnable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.Handler._post6160, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._post6160, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _postAtTime6161;
		public virtual bool postAtTime(java.lang.Runnable arg0, java.lang.Object arg1, long arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.Handler._postAtTime6161, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._postAtTime6161, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _postAtTime6162;
		public virtual bool postAtTime(java.lang.Runnable arg0, long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.Handler._postAtTime6162, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._postAtTime6162, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _postDelayed6163;
		public virtual bool postDelayed(java.lang.Runnable arg0, long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.Handler._postDelayed6163, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._postDelayed6163, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _postAtFrontOfQueue6164;
		public virtual bool postAtFrontOfQueue(java.lang.Runnable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.Handler._postAtFrontOfQueue6164, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._postAtFrontOfQueue6164, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeCallbacks6165;
		public virtual void removeCallbacks(java.lang.Runnable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Handler._removeCallbacks6165, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._removeCallbacks6165, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeCallbacks6166;
		public virtual void removeCallbacks(java.lang.Runnable arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Handler._removeCallbacks6166, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._removeCallbacks6166, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendMessage6167;
		public virtual bool sendMessage(android.os.Message arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.Handler._sendMessage6167, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._sendMessage6167, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendEmptyMessage6168;
		public virtual bool sendEmptyMessage(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.Handler._sendEmptyMessage6168, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._sendEmptyMessage6168, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendEmptyMessageDelayed6169;
		public virtual bool sendEmptyMessageDelayed(int arg0, long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.Handler._sendEmptyMessageDelayed6169, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._sendEmptyMessageDelayed6169, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendEmptyMessageAtTime6170;
		public virtual bool sendEmptyMessageAtTime(int arg0, long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.Handler._sendEmptyMessageAtTime6170, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._sendEmptyMessageAtTime6170, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendMessageDelayed6171;
		public virtual bool sendMessageDelayed(android.os.Message arg0, long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.Handler._sendMessageDelayed6171, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._sendMessageDelayed6171, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendMessageAtTime6172;
		public virtual bool sendMessageAtTime(android.os.Message arg0, long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.Handler._sendMessageAtTime6172, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._sendMessageAtTime6172, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendMessageAtFrontOfQueue6173;
		public virtual bool sendMessageAtFrontOfQueue(android.os.Message arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.Handler._sendMessageAtFrontOfQueue6173, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._sendMessageAtFrontOfQueue6173, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeMessages6174;
		public virtual void removeMessages(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Handler._removeMessages6174, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._removeMessages6174, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeMessages6175;
		public virtual void removeMessages(int arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Handler._removeMessages6175, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._removeMessages6175, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeCallbacksAndMessages6176;
		public virtual void removeCallbacksAndMessages(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Handler._removeCallbacksAndMessages6176, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._removeCallbacksAndMessages6176, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasMessages6177;
		public virtual bool hasMessages(int arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.Handler._hasMessages6177, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._hasMessages6177, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasMessages6178;
		public virtual bool hasMessages(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.Handler._hasMessages6178, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Handler.staticClass, global::android.os.Handler._hasMessages6178, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLooper6179;
		public virtual global::android.os.Looper getLooper() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Looper>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Handler._getLooper6179));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Looper>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Handler.staticClass, global::android.os.Handler._getLooper6179));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Handler6180;
		public Handler()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.os.Handler.staticClass, global::android.os.Handler._Handler6180, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Handler6181;
		public Handler(android.os.Handler.Callback arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.os.Handler.staticClass, global::android.os.Handler._Handler6181, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Handler6182;
		public Handler(android.os.Looper arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.os.Handler.staticClass, global::android.os.Handler._Handler6182, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Handler6183;
		public Handler(android.os.Looper arg0, android.os.Handler.Callback arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.os.Handler.staticClass, global::android.os.Handler._Handler6183, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.os.Handler.staticClass = @__class;
			global::android.os.Handler._toString6151 = @__env.GetMethodID(global::android.os.Handler.staticClass, "toString", "()Ljava/lang/String;");
			global::android.os.Handler._dump6152 = @__env.GetMethodID(global::android.os.Handler.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.os.Handler._handleMessage6153 = @__env.GetMethodID(global::android.os.Handler.staticClass, "handleMessage", "(Landroid/os/Message;)V");
			global::android.os.Handler._dispatchMessage6154 = @__env.GetMethodID(global::android.os.Handler.staticClass, "dispatchMessage", "(Landroid/os/Message;)V");
			global::android.os.Handler._obtainMessage6155 = @__env.GetMethodID(global::android.os.Handler.staticClass, "obtainMessage", "(ILjava/lang/Object;)Landroid/os/Message;");
			global::android.os.Handler._obtainMessage6156 = @__env.GetMethodID(global::android.os.Handler.staticClass, "obtainMessage", "(III)Landroid/os/Message;");
			global::android.os.Handler._obtainMessage6157 = @__env.GetMethodID(global::android.os.Handler.staticClass, "obtainMessage", "(IIILjava/lang/Object;)Landroid/os/Message;");
			global::android.os.Handler._obtainMessage6158 = @__env.GetMethodID(global::android.os.Handler.staticClass, "obtainMessage", "(I)Landroid/os/Message;");
			global::android.os.Handler._obtainMessage6159 = @__env.GetMethodID(global::android.os.Handler.staticClass, "obtainMessage", "()Landroid/os/Message;");
			global::android.os.Handler._post6160 = @__env.GetMethodID(global::android.os.Handler.staticClass, "post", "(Ljava/lang/Runnable;)Z");
			global::android.os.Handler._postAtTime6161 = @__env.GetMethodID(global::android.os.Handler.staticClass, "postAtTime", "(Ljava/lang/Runnable;Ljava/lang/Object;J)Z");
			global::android.os.Handler._postAtTime6162 = @__env.GetMethodID(global::android.os.Handler.staticClass, "postAtTime", "(Ljava/lang/Runnable;J)Z");
			global::android.os.Handler._postDelayed6163 = @__env.GetMethodID(global::android.os.Handler.staticClass, "postDelayed", "(Ljava/lang/Runnable;J)Z");
			global::android.os.Handler._postAtFrontOfQueue6164 = @__env.GetMethodID(global::android.os.Handler.staticClass, "postAtFrontOfQueue", "(Ljava/lang/Runnable;)Z");
			global::android.os.Handler._removeCallbacks6165 = @__env.GetMethodID(global::android.os.Handler.staticClass, "removeCallbacks", "(Ljava/lang/Runnable;)V");
			global::android.os.Handler._removeCallbacks6166 = @__env.GetMethodID(global::android.os.Handler.staticClass, "removeCallbacks", "(Ljava/lang/Runnable;Ljava/lang/Object;)V");
			global::android.os.Handler._sendMessage6167 = @__env.GetMethodID(global::android.os.Handler.staticClass, "sendMessage", "(Landroid/os/Message;)Z");
			global::android.os.Handler._sendEmptyMessage6168 = @__env.GetMethodID(global::android.os.Handler.staticClass, "sendEmptyMessage", "(I)Z");
			global::android.os.Handler._sendEmptyMessageDelayed6169 = @__env.GetMethodID(global::android.os.Handler.staticClass, "sendEmptyMessageDelayed", "(IJ)Z");
			global::android.os.Handler._sendEmptyMessageAtTime6170 = @__env.GetMethodID(global::android.os.Handler.staticClass, "sendEmptyMessageAtTime", "(IJ)Z");
			global::android.os.Handler._sendMessageDelayed6171 = @__env.GetMethodID(global::android.os.Handler.staticClass, "sendMessageDelayed", "(Landroid/os/Message;J)Z");
			global::android.os.Handler._sendMessageAtTime6172 = @__env.GetMethodID(global::android.os.Handler.staticClass, "sendMessageAtTime", "(Landroid/os/Message;J)Z");
			global::android.os.Handler._sendMessageAtFrontOfQueue6173 = @__env.GetMethodID(global::android.os.Handler.staticClass, "sendMessageAtFrontOfQueue", "(Landroid/os/Message;)Z");
			global::android.os.Handler._removeMessages6174 = @__env.GetMethodID(global::android.os.Handler.staticClass, "removeMessages", "(I)V");
			global::android.os.Handler._removeMessages6175 = @__env.GetMethodID(global::android.os.Handler.staticClass, "removeMessages", "(ILjava/lang/Object;)V");
			global::android.os.Handler._removeCallbacksAndMessages6176 = @__env.GetMethodID(global::android.os.Handler.staticClass, "removeCallbacksAndMessages", "(Ljava/lang/Object;)V");
			global::android.os.Handler._hasMessages6177 = @__env.GetMethodID(global::android.os.Handler.staticClass, "hasMessages", "(ILjava/lang/Object;)Z");
			global::android.os.Handler._hasMessages6178 = @__env.GetMethodID(global::android.os.Handler.staticClass, "hasMessages", "(I)Z");
			global::android.os.Handler._getLooper6179 = @__env.GetMethodID(global::android.os.Handler.staticClass, "getLooper", "()Landroid/os/Looper;");
			global::android.os.Handler._Handler6180 = @__env.GetMethodID(global::android.os.Handler.staticClass, "<init>", "()V");
			global::android.os.Handler._Handler6181 = @__env.GetMethodID(global::android.os.Handler.staticClass, "<init>", "(Landroid/os/Handler$Callback;)V");
			global::android.os.Handler._Handler6182 = @__env.GetMethodID(global::android.os.Handler.staticClass, "<init>", "(Landroid/os/Looper;)V");
			global::android.os.Handler._Handler6183 = @__env.GetMethodID(global::android.os.Handler.staticClass, "<init>", "(Landroid/os/Looper;Landroid/os/Handler$Callback;)V");
		}
	}
}
