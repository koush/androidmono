namespace android.speech
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class RecognitionService : android.app.Service
	{
		internal new static global::java.lang.Class staticClass;
		static RecognitionService()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.speech.RecognitionService), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected RecognitionService(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class Callback : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static Callback()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.speech.RecognitionService.Callback), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.speech.RecognitionService.Callback(@__env);
				}
			}
			protected Callback(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _error7014;
			public virtual void error(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.speech.RecognitionService.Callback._error7014, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.speech.RecognitionService.Callback.staticClass, global::android.speech.RecognitionService.Callback._error7014, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _results7015;
			public virtual void results(android.os.Bundle arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.speech.RecognitionService.Callback._results7015, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.speech.RecognitionService.Callback.staticClass, global::android.speech.RecognitionService.Callback._results7015, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _beginningOfSpeech7016;
			public virtual void beginningOfSpeech() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.speech.RecognitionService.Callback._beginningOfSpeech7016);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.speech.RecognitionService.Callback.staticClass, global::android.speech.RecognitionService.Callback._beginningOfSpeech7016);
			}
			internal static global::net.sf.jni4net.jni.MethodId _bufferReceived7017;
			public virtual void bufferReceived(byte[] arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.speech.RecognitionService.Callback._bufferReceived7017, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.speech.RecognitionService.Callback.staticClass, global::android.speech.RecognitionService.Callback._bufferReceived7017, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _endOfSpeech7018;
			public virtual void endOfSpeech() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.speech.RecognitionService.Callback._endOfSpeech7018);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.speech.RecognitionService.Callback.staticClass, global::android.speech.RecognitionService.Callback._endOfSpeech7018);
			}
			internal static global::net.sf.jni4net.jni.MethodId _partialResults7019;
			public virtual void partialResults(android.os.Bundle arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.speech.RecognitionService.Callback._partialResults7019, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.speech.RecognitionService.Callback.staticClass, global::android.speech.RecognitionService.Callback._partialResults7019, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _readyForSpeech7020;
			public virtual void readyForSpeech(android.os.Bundle arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.speech.RecognitionService.Callback._readyForSpeech7020, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.speech.RecognitionService.Callback.staticClass, global::android.speech.RecognitionService.Callback._readyForSpeech7020, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _rmsChanged7021;
			public virtual void rmsChanged(float arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.speech.RecognitionService.Callback._rmsChanged7021, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.speech.RecognitionService.Callback.staticClass, global::android.speech.RecognitionService.Callback._rmsChanged7021, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.speech.RecognitionService.Callback.staticClass = @__class;
				global::android.speech.RecognitionService.Callback._error7014 = @__env.GetMethodID(global::android.speech.RecognitionService.Callback.staticClass, "error", "(I)V");
				global::android.speech.RecognitionService.Callback._results7015 = @__env.GetMethodID(global::android.speech.RecognitionService.Callback.staticClass, "results", "(Landroid/os/Bundle;)V");
				global::android.speech.RecognitionService.Callback._beginningOfSpeech7016 = @__env.GetMethodID(global::android.speech.RecognitionService.Callback.staticClass, "beginningOfSpeech", "()V");
				global::android.speech.RecognitionService.Callback._bufferReceived7017 = @__env.GetMethodID(global::android.speech.RecognitionService.Callback.staticClass, "bufferReceived", "([B)V");
				global::android.speech.RecognitionService.Callback._endOfSpeech7018 = @__env.GetMethodID(global::android.speech.RecognitionService.Callback.staticClass, "endOfSpeech", "()V");
				global::android.speech.RecognitionService.Callback._partialResults7019 = @__env.GetMethodID(global::android.speech.RecognitionService.Callback.staticClass, "partialResults", "(Landroid/os/Bundle;)V");
				global::android.speech.RecognitionService.Callback._readyForSpeech7020 = @__env.GetMethodID(global::android.speech.RecognitionService.Callback.staticClass, "readyForSpeech", "(Landroid/os/Bundle;)V");
				global::android.speech.RecognitionService.Callback._rmsChanged7021 = @__env.GetMethodID(global::android.speech.RecognitionService.Callback.staticClass, "rmsChanged", "(F)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _onBind7022;
		public sealed override global::android.os.IBinder onBind(android.content.Intent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallObjectMethodPtr(this, global::android.speech.RecognitionService._onBind7022, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.speech.RecognitionService.staticClass, global::android.speech.RecognitionService._onBind7022, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDestroy7023;
		public override void onDestroy() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.speech.RecognitionService._onDestroy7023);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.speech.RecognitionService.staticClass, global::android.speech.RecognitionService._onDestroy7023);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCancel7024;
		protected abstract void onCancel(android.speech.RecognitionService.Callback arg0);
		internal static global::net.sf.jni4net.jni.MethodId _onStartListening7025;
		protected abstract void onStartListening(android.content.Intent arg0, android.speech.RecognitionService.Callback arg1);
		internal static global::net.sf.jni4net.jni.MethodId _onStopListening7026;
		protected abstract void onStopListening(android.speech.RecognitionService.Callback arg0);
		internal static global::net.sf.jni4net.jni.MethodId _RecognitionService7027;
		public RecognitionService()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.speech.RecognitionService.staticClass, global::android.speech.RecognitionService._RecognitionService7027, this);
		}
		public static global::java.lang.String SERVICE_INTERFACE
		{
			get
			{
				return "android.speech.RecognitionService";
			}
		}
		public static global::java.lang.String SERVICE_META_DATA
		{
			get
			{
				return "android.speech";
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.speech.RecognitionService.staticClass = @__class;
			global::android.speech.RecognitionService._onBind7022 = @__env.GetMethodID(global::android.speech.RecognitionService.staticClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");
			global::android.speech.RecognitionService._onDestroy7023 = @__env.GetMethodID(global::android.speech.RecognitionService.staticClass, "onDestroy", "()V");
			global::android.speech.RecognitionService._onCancel7024 = @__env.GetMethodID(global::android.speech.RecognitionService.staticClass, "onCancel", "(Landroid/speech/RecognitionService$Callback;)V");
			global::android.speech.RecognitionService._onStartListening7025 = @__env.GetMethodID(global::android.speech.RecognitionService.staticClass, "onStartListening", "(Landroid/content/Intent;Landroid/speech/RecognitionService$Callback;)V");
			global::android.speech.RecognitionService._onStopListening7026 = @__env.GetMethodID(global::android.speech.RecognitionService.staticClass, "onStopListening", "(Landroid/speech/RecognitionService$Callback;)V");
			global::android.speech.RecognitionService._RecognitionService7027 = @__env.GetMethodID(global::android.speech.RecognitionService.staticClass, "<init>", "()V");
		}
	}
}
