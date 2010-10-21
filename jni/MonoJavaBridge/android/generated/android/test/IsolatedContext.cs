namespace android.test
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IsolatedContext : android.content.ContextWrapper
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IsolatedContext()
		{
			InitJNI();
		}
		protected IsolatedContext(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::android.content.ContentResolver ContentResolver
		{
			get
			{
				return getContentResolver();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentResolver12163;
		public override global::android.content.ContentResolver getContentResolver() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.IsolatedContext._getContentResolver12163)) as android.content.ContentResolver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.IsolatedContext.staticClass, global::android.test.IsolatedContext._getContentResolver12163)) as android.content.ContentResolver;
		}
		public new global::java.io.File FilesDir
		{
			get
			{
				return getFilesDir();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFilesDir12164;
		public override global::java.io.File getFilesDir() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.IsolatedContext._getFilesDir12164)) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.IsolatedContext.staticClass, global::android.test.IsolatedContext._getFilesDir12164)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _sendBroadcast12165;
		public override void sendBroadcast(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.IsolatedContext._sendBroadcast12165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.IsolatedContext.staticClass, global::android.test.IsolatedContext._sendBroadcast12165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendOrderedBroadcast12166;
		public override void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.IsolatedContext._sendOrderedBroadcast12166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.IsolatedContext.staticClass, global::android.test.IsolatedContext._sendOrderedBroadcast12166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _registerReceiver12167;
		public override global::android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.IsolatedContext._registerReceiver12167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.IsolatedContext.staticClass, global::android.test.IsolatedContext._registerReceiver12167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _bindService12168;
		public override bool bindService(android.content.Intent arg0, android.content.ServiceConnection arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.IsolatedContext._bindService12168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.IsolatedContext.staticClass, global::android.test.IsolatedContext._bindService12168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getSystemService12169;
		public override global::java.lang.Object getSystemService(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.IsolatedContext._getSystemService12169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.IsolatedContext.staticClass, global::android.test.IsolatedContext._getSystemService12169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _checkUriPermission12170;
		public override int checkUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.IsolatedContext._checkUriPermission12170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.IsolatedContext.staticClass, global::android.test.IsolatedContext._checkUriPermission12170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _checkUriPermission12171;
		public override int checkUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.IsolatedContext._checkUriPermission12171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.IsolatedContext.staticClass, global::android.test.IsolatedContext._checkUriPermission12171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new global::java.util.List AndClearBroadcastIntents
		{
			get
			{
				return getAndClearBroadcastIntents();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAndClearBroadcastIntents12172;
		public virtual global::java.util.List getAndClearBroadcastIntents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.IsolatedContext._getAndClearBroadcastIntents12172)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.IsolatedContext.staticClass, global::android.test.IsolatedContext._getAndClearBroadcastIntents12172)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _IsolatedContext12173;
		public IsolatedContext(android.content.ContentResolver arg0, android.content.Context arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.IsolatedContext.staticClass, global::android.test.IsolatedContext._IsolatedContext12173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.IsolatedContext.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/IsolatedContext"));
			global::android.test.IsolatedContext._getContentResolver12163 = @__env.GetMethodIDNoThrow(global::android.test.IsolatedContext.staticClass, "getContentResolver", "()Landroid/content/ContentResolver;");
			global::android.test.IsolatedContext._getFilesDir12164 = @__env.GetMethodIDNoThrow(global::android.test.IsolatedContext.staticClass, "getFilesDir", "()Ljava/io/File;");
			global::android.test.IsolatedContext._sendBroadcast12165 = @__env.GetMethodIDNoThrow(global::android.test.IsolatedContext.staticClass, "sendBroadcast", "(Landroid/content/Intent;)V");
			global::android.test.IsolatedContext._sendOrderedBroadcast12166 = @__env.GetMethodIDNoThrow(global::android.test.IsolatedContext.staticClass, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V");
			global::android.test.IsolatedContext._registerReceiver12167 = @__env.GetMethodIDNoThrow(global::android.test.IsolatedContext.staticClass, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/content/Intent;");
			global::android.test.IsolatedContext._bindService12168 = @__env.GetMethodIDNoThrow(global::android.test.IsolatedContext.staticClass, "bindService", "(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z");
			global::android.test.IsolatedContext._getSystemService12169 = @__env.GetMethodIDNoThrow(global::android.test.IsolatedContext.staticClass, "getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::android.test.IsolatedContext._checkUriPermission12170 = @__env.GetMethodIDNoThrow(global::android.test.IsolatedContext.staticClass, "checkUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;III)I");
			global::android.test.IsolatedContext._checkUriPermission12171 = @__env.GetMethodIDNoThrow(global::android.test.IsolatedContext.staticClass, "checkUriPermission", "(Landroid/net/Uri;III)I");
			global::android.test.IsolatedContext._getAndClearBroadcastIntents12172 = @__env.GetMethodIDNoThrow(global::android.test.IsolatedContext.staticClass, "getAndClearBroadcastIntents", "()Ljava/util/List;");
			global::android.test.IsolatedContext._IsolatedContext12173 = @__env.GetMethodIDNoThrow(global::android.test.IsolatedContext.staticClass, "<init>", "(Landroid/content/ContentResolver;Landroid/content/Context;)V");
		}
	}
}
