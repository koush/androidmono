namespace android.provider
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SyncStateContract : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SyncStateContract(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.SyncStateContract.Columns_))]
		public partial interface Columns : BaseColumns
		{
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.SyncStateContract.Columns))]
		internal sealed partial class Columns_ : java.lang.Object, Columns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Columns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			static Columns_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.SyncStateContract.Columns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/SyncStateContract$Columns"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public static partial class ColumnsConstants 
		{
			public static global::java.lang.String ACCOUNT_NAME
			{
				get
				{
					return "account_name";
				}
			}
			public static global::java.lang.String ACCOUNT_TYPE
			{
				get
				{
					return "account_type";
				}
			}
			public static global::java.lang.String DATA
			{
				get
				{
					return "data";
				}
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Constants : java.lang.Object, Columns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected Constants(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public Constants() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.SyncStateContract.Constants._m0.native == global::System.IntPtr.Zero)
					global::android.provider.SyncStateContract.Constants._m0 = @__env.GetMethodIDNoThrow(global::android.provider.SyncStateContract.Constants.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.SyncStateContract.Constants.staticClass, global::android.provider.SyncStateContract.Constants._m0);
				Init(@__env, handle);
			}
			public static global::java.lang.String CONTENT_DIRECTORY
			{
				get
				{
					return "syncstate";
				}
			}
			static Constants()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.SyncStateContract.Constants.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/SyncStateContract$Constants"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Helpers : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Helpers(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static byte[] get(android.content.ContentProviderClient arg0, android.net.Uri arg1, android.accounts.Account arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.SyncStateContract.Helpers._m0.native == global::System.IntPtr.Zero)
					global::android.provider.SyncStateContract.Helpers._m0 = @__env.GetStaticMethodIDNoThrow(global::android.provider.SyncStateContract.Helpers.staticClass, "get", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Account;)[B");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.provider.SyncStateContract.Helpers.staticClass, global::android.provider.SyncStateContract.Helpers._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as byte[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static void set(android.content.ContentProviderClient arg0, android.net.Uri arg1, android.accounts.Account arg2, byte[] arg3)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.SyncStateContract.Helpers._m1.native == global::System.IntPtr.Zero)
					global::android.provider.SyncStateContract.Helpers._m1 = @__env.GetStaticMethodIDNoThrow(global::android.provider.SyncStateContract.Helpers.staticClass, "set", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Account;[B)V");
				@__env.CallStaticVoidMethod(android.provider.SyncStateContract.Helpers.staticClass, global::android.provider.SyncStateContract.Helpers._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public static global::android.net.Uri insert(android.content.ContentProviderClient arg0, android.net.Uri arg1, android.accounts.Account arg2, byte[] arg3)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.SyncStateContract.Helpers._m2.native == global::System.IntPtr.Zero)
					global::android.provider.SyncStateContract.Helpers._m2 = @__env.GetStaticMethodIDNoThrow(global::android.provider.SyncStateContract.Helpers.staticClass, "insert", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Account;[B)Landroid/net/Uri;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.SyncStateContract.Helpers.staticClass, global::android.provider.SyncStateContract.Helpers._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.net.Uri;
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public static void update(android.content.ContentProviderClient arg0, android.net.Uri arg1, byte[] arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.SyncStateContract.Helpers._m3.native == global::System.IntPtr.Zero)
					global::android.provider.SyncStateContract.Helpers._m3 = @__env.GetStaticMethodIDNoThrow(global::android.provider.SyncStateContract.Helpers.staticClass, "update", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;[B)V");
				@__env.CallStaticVoidMethod(android.provider.SyncStateContract.Helpers.staticClass, global::android.provider.SyncStateContract.Helpers._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public static global::android.util.Pair getWithUri(android.content.ContentProviderClient arg0, android.net.Uri arg1, android.accounts.Account arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.SyncStateContract.Helpers._m4.native == global::System.IntPtr.Zero)
					global::android.provider.SyncStateContract.Helpers._m4 = @__env.GetStaticMethodIDNoThrow(global::android.provider.SyncStateContract.Helpers.staticClass, "getWithUri", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Account;)Landroid/util/Pair;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.SyncStateContract.Helpers.staticClass, global::android.provider.SyncStateContract.Helpers._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.util.Pair;
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public static global::android.content.ContentProviderOperation newSetOperation(android.net.Uri arg0, android.accounts.Account arg1, byte[] arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.SyncStateContract.Helpers._m5.native == global::System.IntPtr.Zero)
					global::android.provider.SyncStateContract.Helpers._m5 = @__env.GetStaticMethodIDNoThrow(global::android.provider.SyncStateContract.Helpers.staticClass, "newSetOperation", "(Landroid/net/Uri;Landroid/accounts/Account;[B)Landroid/content/ContentProviderOperation;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.SyncStateContract.Helpers.staticClass, global::android.provider.SyncStateContract.Helpers._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.content.ContentProviderOperation;
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public static global::android.content.ContentProviderOperation newUpdateOperation(android.net.Uri arg0, byte[] arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.SyncStateContract.Helpers._m6.native == global::System.IntPtr.Zero)
					global::android.provider.SyncStateContract.Helpers._m6 = @__env.GetStaticMethodIDNoThrow(global::android.provider.SyncStateContract.Helpers.staticClass, "newUpdateOperation", "(Landroid/net/Uri;[B)Landroid/content/ContentProviderOperation;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.SyncStateContract.Helpers.staticClass, global::android.provider.SyncStateContract.Helpers._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.ContentProviderOperation;
			}
			private static global::MonoJavaBridge.MethodId _m7;
			public Helpers() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.SyncStateContract.Helpers._m7.native == global::System.IntPtr.Zero)
					global::android.provider.SyncStateContract.Helpers._m7 = @__env.GetMethodIDNoThrow(global::android.provider.SyncStateContract.Helpers.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.SyncStateContract.Helpers.staticClass, global::android.provider.SyncStateContract.Helpers._m7);
				Init(@__env, handle);
			}
			static Helpers()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.SyncStateContract.Helpers.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/SyncStateContract$Helpers"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public SyncStateContract() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.provider.SyncStateContract._m0.native == global::System.IntPtr.Zero)
				global::android.provider.SyncStateContract._m0 = @__env.GetMethodIDNoThrow(global::android.provider.SyncStateContract.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.SyncStateContract.staticClass, global::android.provider.SyncStateContract._m0);
			Init(@__env, handle);
		}
		static SyncStateContract()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.provider.SyncStateContract.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/SyncStateContract"));
		}
	}
}
