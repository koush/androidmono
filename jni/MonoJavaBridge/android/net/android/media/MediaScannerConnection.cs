namespace android.media 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class MediaScannerConnection : java.lang.Object, android.content.ServiceConnection
	{ 
		internal static global::java.lang.Class staticClass; 
		static MediaScannerConnection() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.media.MediaScannerConnection), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.media.MediaScannerConnection(@__env); 
			} 
		} 
		protected MediaScannerConnection(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface MediaScannerConnectionClient 
		{ 
			void onMediaScannerConnected(); 
			void onScanCompleted(java.lang.String arg0, android.net.Uri arg1); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _connect4311; 
		public virtual void connect() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaScannerConnection)) 
				@__env.CallVoidMethod(this, _connect4311); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaScannerConnection.staticClass, _connect4311); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onServiceConnected4312; 
		public virtual void onServiceConnected(android.content.ComponentName arg0, android.os.IBinder arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaScannerConnection)) 
				@__env.CallVoidMethod(this, _onServiceConnected4312, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaScannerConnection.staticClass, _onServiceConnected4312, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onServiceDisconnected4313; 
		public virtual void onServiceDisconnected(android.content.ComponentName arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaScannerConnection)) 
				@__env.CallVoidMethod(this, _onServiceDisconnected4313, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaScannerConnection.staticClass, _onServiceDisconnected4313, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _disconnect4314; 
		public virtual void disconnect() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaScannerConnection)) 
				@__env.CallVoidMethod(this, _disconnect4314); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaScannerConnection.staticClass, _disconnect4314); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isConnected4315; 
		public virtual bool isConnected() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaScannerConnection)) 
				return @__env.CallBooleanMethod(this, _isConnected4315); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.media.MediaScannerConnection.staticClass, _isConnected4315); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _scanFile4316; 
		public virtual void scanFile(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaScannerConnection)) 
				@__env.CallVoidMethod(this, _scanFile4316, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaScannerConnection.staticClass, _scanFile4316, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _MediaScannerConnection4317; 
		public MediaScannerConnection(android.content.Context arg0, android.media.MediaScannerConnection.MediaScannerConnectionClient arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.media.MediaScannerConnection.staticClass, _MediaScannerConnection4317, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.media.MediaScannerConnection.staticClass = @__class; 
			global::android.media.MediaScannerConnection._connect4311 = @__env.GetMethodID(global::android.media.MediaScannerConnection.staticClass, "connect", "()V"); 
			global::android.media.MediaScannerConnection._onServiceConnected4312 = @__env.GetMethodID(global::android.media.MediaScannerConnection.staticClass, "onServiceConnected", "(Landroid/content/ComponentName;Landroid/os/IBinder;)V"); 
			global::android.media.MediaScannerConnection._onServiceDisconnected4313 = @__env.GetMethodID(global::android.media.MediaScannerConnection.staticClass, "onServiceDisconnected", "(Landroid/content/ComponentName;)V"); 
			global::android.media.MediaScannerConnection._disconnect4314 = @__env.GetMethodID(global::android.media.MediaScannerConnection.staticClass, "disconnect", "()V"); 
			global::android.media.MediaScannerConnection._isConnected4315 = @__env.GetMethodID(global::android.media.MediaScannerConnection.staticClass, "isConnected", "()Z"); 
			global::android.media.MediaScannerConnection._scanFile4316 = @__env.GetMethodID(global::android.media.MediaScannerConnection.staticClass, "scanFile", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.media.MediaScannerConnection._MediaScannerConnection4317 = @__env.GetMethodID(global::android.media.MediaScannerConnection.staticClass, "<init>", "(Landroid/content/Context;Landroid/media/MediaScannerConnection$MediaScannerConnectionClient;)V"); 
		} 
	} 
} 
