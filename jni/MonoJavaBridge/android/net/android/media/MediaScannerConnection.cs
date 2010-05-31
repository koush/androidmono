namespace android.media 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class MediaScannerConnection : java.lang.Object, android.content.ServiceConnection
	{ 
		internal static global::java.lang.Class staticClass; 
		static MediaScannerConnection() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.MediaScannerConnection), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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

		public partial class MediaScannerConnectionClient_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __MediaScannerConnectionClient.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __MediaScannerConnectionClient : java.lang.Object, MediaScannerConnectionClient
		{ 
			internal static global::java.lang.Class staticClass; 
			static __MediaScannerConnectionClient() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.MediaScannerConnection.__MediaScannerConnectionClient), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.media.MediaScannerConnection.__MediaScannerConnectionClient(@__env); 
				} 
			} 
			internal __MediaScannerConnectionClient(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onMediaScannerConnected4557; 
			 void android.media.MediaScannerConnection.MediaScannerConnectionClient.onMediaScannerConnected() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.media.MediaScannerConnection.__MediaScannerConnectionClient._onMediaScannerConnected4557); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaScannerConnection.__MediaScannerConnectionClient.staticClass, global::android.media.MediaScannerConnection.__MediaScannerConnectionClient._onMediaScannerConnected4557); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onScanCompleted4558; 
			 void android.media.MediaScannerConnection.MediaScannerConnectionClient.onScanCompleted(java.lang.String arg0, android.net.Uri arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.media.MediaScannerConnection.__MediaScannerConnectionClient._onScanCompleted4558, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaScannerConnection.__MediaScannerConnectionClient.staticClass, global::android.media.MediaScannerConnection.__MediaScannerConnectionClient._onScanCompleted4558, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.media.MediaScannerConnection.__MediaScannerConnectionClient.staticClass = @__class; 
				global::android.media.MediaScannerConnection.__MediaScannerConnectionClient._onMediaScannerConnected4557 = @__env.GetMethodID(global::android.media.MediaScannerConnection.__MediaScannerConnectionClient.staticClass, "android.media.MediaScannerConnection.MediaScannerConnectionClient.onMediaScannerConnected", "()V"); 
				global::android.media.MediaScannerConnection.__MediaScannerConnectionClient._onScanCompleted4558 = @__env.GetMethodID(global::android.media.MediaScannerConnection.__MediaScannerConnectionClient.staticClass, "android.media.MediaScannerConnection.MediaScannerConnectionClient.onScanCompleted", "(Ljava/lang/String;Landroid/net/Uri;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _connect4559; 
		public virtual void connect() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.MediaScannerConnection._connect4559); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaScannerConnection.staticClass, global::android.media.MediaScannerConnection._connect4559); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onServiceConnected4560; 
		public virtual void onServiceConnected(android.content.ComponentName arg0, android.os.IBinder arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.MediaScannerConnection._onServiceConnected4560, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaScannerConnection.staticClass, global::android.media.MediaScannerConnection._onServiceConnected4560, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onServiceDisconnected4561; 
		public virtual void onServiceDisconnected(android.content.ComponentName arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.MediaScannerConnection._onServiceDisconnected4561, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaScannerConnection.staticClass, global::android.media.MediaScannerConnection._onServiceDisconnected4561, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _disconnect4562; 
		public virtual void disconnect() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.MediaScannerConnection._disconnect4562); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaScannerConnection.staticClass, global::android.media.MediaScannerConnection._disconnect4562); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isConnected4563; 
		public virtual bool isConnected() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.media.MediaScannerConnection._isConnected4563); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.MediaScannerConnection.staticClass, global::android.media.MediaScannerConnection._isConnected4563); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _scanFile4564; 
		public virtual void scanFile(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.MediaScannerConnection._scanFile4564, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaScannerConnection.staticClass, global::android.media.MediaScannerConnection._scanFile4564, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _MediaScannerConnection4565; 
		public MediaScannerConnection(android.content.Context arg0, android.media.MediaScannerConnection.MediaScannerConnectionClient arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.media.MediaScannerConnection.staticClass, global::android.media.MediaScannerConnection._MediaScannerConnection4565, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.media.MediaScannerConnection.staticClass = @__class; 
			global::android.media.MediaScannerConnection._connect4559 = @__env.GetMethodID(global::android.media.MediaScannerConnection.staticClass, "connect", "()V"); 
			global::android.media.MediaScannerConnection._onServiceConnected4560 = @__env.GetMethodID(global::android.media.MediaScannerConnection.staticClass, "onServiceConnected", "(Landroid/content/ComponentName;Landroid/os/IBinder;)V"); 
			global::android.media.MediaScannerConnection._onServiceDisconnected4561 = @__env.GetMethodID(global::android.media.MediaScannerConnection.staticClass, "onServiceDisconnected", "(Landroid/content/ComponentName;)V"); 
			global::android.media.MediaScannerConnection._disconnect4562 = @__env.GetMethodID(global::android.media.MediaScannerConnection.staticClass, "disconnect", "()V"); 
			global::android.media.MediaScannerConnection._isConnected4563 = @__env.GetMethodID(global::android.media.MediaScannerConnection.staticClass, "isConnected", "()Z"); 
			global::android.media.MediaScannerConnection._scanFile4564 = @__env.GetMethodID(global::android.media.MediaScannerConnection.staticClass, "scanFile", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.media.MediaScannerConnection._MediaScannerConnection4565 = @__env.GetMethodID(global::android.media.MediaScannerConnection.staticClass, "<init>", "(Landroid/content/Context;Landroid/media/MediaScannerConnection$MediaScannerConnectionClient;)V"); 
		} 
	} 
} 
