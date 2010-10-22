namespace android.provider
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SyncStateContract : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SyncStateContract()
		{
			InitJNI();
		}
		protected SyncStateContract(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.SyncStateContract.Columns_))]
		public partial interface Columns : BaseColumns
		{
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.SyncStateContract.Columns))]
		public sealed partial class Columns_ : java.lang.Object, Columns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Columns_()
			{
				InitJNI();
			}
			internal Columns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static void InitJNI()
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
			static Constants()
			{
				InitJNI();
			}
			protected Constants(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _Constants11519;
			public Constants()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.SyncStateContract.Constants.staticClass, global::android.provider.SyncStateContract.Constants._Constants11519);
				Init(@__env, handle);
			}
			public static global::java.lang.String CONTENT_DIRECTORY
			{
				get
				{
					return "syncstate";
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.SyncStateContract.Constants.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/SyncStateContract$Constants"));
				global::android.provider.SyncStateContract.Constants._Constants11519 = @__env.GetMethodIDNoThrow(global::android.provider.SyncStateContract.Constants.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Helpers : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Helpers()
			{
				InitJNI();
			}
			internal Helpers(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _get11521;
			public static byte[] get(android.content.ContentProviderClient arg0, android.net.Uri arg1, android.accounts.Account arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.provider.SyncStateContract.Helpers.staticClass, global::android.provider.SyncStateContract.Helpers._get11521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as byte[];
			}
			internal static global::MonoJavaBridge.MethodId _set11522;
			public static void set(android.content.ContentProviderClient arg0, android.net.Uri arg1, android.accounts.Account arg2, byte[] arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallStaticVoidMethod(android.provider.SyncStateContract.Helpers.staticClass, global::android.provider.SyncStateContract.Helpers._set11522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			internal static global::MonoJavaBridge.MethodId _insert11523;
			public static global::android.net.Uri insert(android.content.ContentProviderClient arg0, android.net.Uri arg1, android.accounts.Account arg2, byte[] arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.SyncStateContract.Helpers.staticClass, global::android.provider.SyncStateContract.Helpers._insert11523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.net.Uri;
			}
			internal static global::MonoJavaBridge.MethodId _update11524;
			public static void update(android.content.ContentProviderClient arg0, android.net.Uri arg1, byte[] arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallStaticVoidMethod(android.provider.SyncStateContract.Helpers.staticClass, global::android.provider.SyncStateContract.Helpers._update11524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _getWithUri11525;
			public static global::android.util.Pair getWithUri(android.content.ContentProviderClient arg0, android.net.Uri arg1, android.accounts.Account arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.SyncStateContract.Helpers.staticClass, global::android.provider.SyncStateContract.Helpers._getWithUri11525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.util.Pair;
			}
			internal static global::MonoJavaBridge.MethodId _newSetOperation11526;
			public static global::android.content.ContentProviderOperation newSetOperation(android.net.Uri arg0, android.accounts.Account arg1, byte[] arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.SyncStateContract.Helpers.staticClass, global::android.provider.SyncStateContract.Helpers._newSetOperation11526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.content.ContentProviderOperation;
			}
			internal static global::MonoJavaBridge.MethodId _newUpdateOperation11527;
			public static global::android.content.ContentProviderOperation newUpdateOperation(android.net.Uri arg0, byte[] arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.SyncStateContract.Helpers.staticClass, global::android.provider.SyncStateContract.Helpers._newUpdateOperation11527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.ContentProviderOperation;
			}
			internal static global::MonoJavaBridge.MethodId _Helpers11528;
			public Helpers()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.SyncStateContract.Helpers.staticClass, global::android.provider.SyncStateContract.Helpers._Helpers11528);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.SyncStateContract.Helpers.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/SyncStateContract$Helpers"));
				global::android.provider.SyncStateContract.Helpers._get11521 = @__env.GetStaticMethodIDNoThrow(global::android.provider.SyncStateContract.Helpers.staticClass, "get", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Account;)[B");
				global::android.provider.SyncStateContract.Helpers._set11522 = @__env.GetStaticMethodIDNoThrow(global::android.provider.SyncStateContract.Helpers.staticClass, "set", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Account;[B)V");
				global::android.provider.SyncStateContract.Helpers._insert11523 = @__env.GetStaticMethodIDNoThrow(global::android.provider.SyncStateContract.Helpers.staticClass, "insert", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Account;[B)Landroid/net/Uri;");
				global::android.provider.SyncStateContract.Helpers._update11524 = @__env.GetStaticMethodIDNoThrow(global::android.provider.SyncStateContract.Helpers.staticClass, "update", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;[B)V");
				global::android.provider.SyncStateContract.Helpers._getWithUri11525 = @__env.GetStaticMethodIDNoThrow(global::android.provider.SyncStateContract.Helpers.staticClass, "getWithUri", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Account;)Landroid/util/Pair;");
				global::android.provider.SyncStateContract.Helpers._newSetOperation11526 = @__env.GetStaticMethodIDNoThrow(global::android.provider.SyncStateContract.Helpers.staticClass, "newSetOperation", "(Landroid/net/Uri;Landroid/accounts/Account;[B)Landroid/content/ContentProviderOperation;");
				global::android.provider.SyncStateContract.Helpers._newUpdateOperation11527 = @__env.GetStaticMethodIDNoThrow(global::android.provider.SyncStateContract.Helpers.staticClass, "newUpdateOperation", "(Landroid/net/Uri;[B)Landroid/content/ContentProviderOperation;");
				global::android.provider.SyncStateContract.Helpers._Helpers11528 = @__env.GetMethodIDNoThrow(global::android.provider.SyncStateContract.Helpers.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _SyncStateContract11529;
		public SyncStateContract()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.SyncStateContract.staticClass, global::android.provider.SyncStateContract._SyncStateContract11529);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.provider.SyncStateContract.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/SyncStateContract"));
			global::android.provider.SyncStateContract._SyncStateContract11529 = @__env.GetMethodIDNoThrow(global::android.provider.SyncStateContract.staticClass, "<init>", "()V");
		}
	}
}
