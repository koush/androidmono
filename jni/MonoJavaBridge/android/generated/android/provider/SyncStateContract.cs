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
		public interface Columns : BaseColumns
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
			internal static global::MonoJavaBridge.MethodId _Constants7224;
			public Constants()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.SyncStateContract.Constants.staticClass, global::android.provider.SyncStateContract.Constants._Constants7224);
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
				global::android.provider.SyncStateContract.Constants._Constants7224 = @__env.GetMethodIDNoThrow(global::android.provider.SyncStateContract.Constants.staticClass, "<init>", "()V");
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
			internal static global::MonoJavaBridge.MethodId _get7225;
			public static byte[] get(android.content.ContentProviderClient arg0, android.net.Uri arg1, android.accounts.Account arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.provider.SyncStateContract.Helpers.staticClass, global::android.provider.SyncStateContract.Helpers._get7225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as byte[];
			}
			internal static global::MonoJavaBridge.MethodId _set7226;
			public static void set(android.content.ContentProviderClient arg0, android.net.Uri arg1, android.accounts.Account arg2, byte[] arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallStaticVoidMethod(android.provider.SyncStateContract.Helpers.staticClass, global::android.provider.SyncStateContract.Helpers._set7226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			internal static global::MonoJavaBridge.MethodId _insert7227;
			public static global::android.net.Uri insert(android.content.ContentProviderClient arg0, android.net.Uri arg1, android.accounts.Account arg2, byte[] arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.SyncStateContract.Helpers.staticClass, global::android.provider.SyncStateContract.Helpers._insert7227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.net.Uri;
			}
			internal static global::MonoJavaBridge.MethodId _update7228;
			public static void update(android.content.ContentProviderClient arg0, android.net.Uri arg1, byte[] arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallStaticVoidMethod(android.provider.SyncStateContract.Helpers.staticClass, global::android.provider.SyncStateContract.Helpers._update7228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _getWithUri7229;
			public static global::android.util.Pair getWithUri(android.content.ContentProviderClient arg0, android.net.Uri arg1, android.accounts.Account arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.SyncStateContract.Helpers.staticClass, global::android.provider.SyncStateContract.Helpers._getWithUri7229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.util.Pair;
			}
			internal static global::MonoJavaBridge.MethodId _newSetOperation7230;
			public static global::android.content.ContentProviderOperation newSetOperation(android.net.Uri arg0, android.accounts.Account arg1, byte[] arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.SyncStateContract.Helpers.staticClass, global::android.provider.SyncStateContract.Helpers._newSetOperation7230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.content.ContentProviderOperation;
			}
			internal static global::MonoJavaBridge.MethodId _newUpdateOperation7231;
			public static global::android.content.ContentProviderOperation newUpdateOperation(android.net.Uri arg0, byte[] arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.SyncStateContract.Helpers.staticClass, global::android.provider.SyncStateContract.Helpers._newUpdateOperation7231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.ContentProviderOperation;
			}
			internal static global::MonoJavaBridge.MethodId _Helpers7232;
			public Helpers()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.SyncStateContract.Helpers.staticClass, global::android.provider.SyncStateContract.Helpers._Helpers7232);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.SyncStateContract.Helpers.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/SyncStateContract$Helpers"));
				global::android.provider.SyncStateContract.Helpers._get7225 = @__env.GetStaticMethodIDNoThrow(global::android.provider.SyncStateContract.Helpers.staticClass, "get", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Account;)[B");
				global::android.provider.SyncStateContract.Helpers._set7226 = @__env.GetStaticMethodIDNoThrow(global::android.provider.SyncStateContract.Helpers.staticClass, "set", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Account;[B)V");
				global::android.provider.SyncStateContract.Helpers._insert7227 = @__env.GetStaticMethodIDNoThrow(global::android.provider.SyncStateContract.Helpers.staticClass, "insert", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Account;[B)Landroid/net/Uri;");
				global::android.provider.SyncStateContract.Helpers._update7228 = @__env.GetStaticMethodIDNoThrow(global::android.provider.SyncStateContract.Helpers.staticClass, "update", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;[B)V");
				global::android.provider.SyncStateContract.Helpers._getWithUri7229 = @__env.GetStaticMethodIDNoThrow(global::android.provider.SyncStateContract.Helpers.staticClass, "getWithUri", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Account;)Landroid/util/Pair;");
				global::android.provider.SyncStateContract.Helpers._newSetOperation7230 = @__env.GetStaticMethodIDNoThrow(global::android.provider.SyncStateContract.Helpers.staticClass, "newSetOperation", "(Landroid/net/Uri;Landroid/accounts/Account;[B)Landroid/content/ContentProviderOperation;");
				global::android.provider.SyncStateContract.Helpers._newUpdateOperation7231 = @__env.GetStaticMethodIDNoThrow(global::android.provider.SyncStateContract.Helpers.staticClass, "newUpdateOperation", "(Landroid/net/Uri;[B)Landroid/content/ContentProviderOperation;");
				global::android.provider.SyncStateContract.Helpers._Helpers7232 = @__env.GetMethodIDNoThrow(global::android.provider.SyncStateContract.Helpers.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _SyncStateContract7233;
		public SyncStateContract()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.SyncStateContract.staticClass, global::android.provider.SyncStateContract._SyncStateContract7233);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.provider.SyncStateContract.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/SyncStateContract"));
			global::android.provider.SyncStateContract._SyncStateContract7233 = @__env.GetMethodIDNoThrow(global::android.provider.SyncStateContract.staticClass, "<init>", "()V");
		}
	}
}
