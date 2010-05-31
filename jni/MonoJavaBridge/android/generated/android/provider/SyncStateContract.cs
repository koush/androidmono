namespace android.provider
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SyncStateContract : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static SyncStateContract()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.SyncStateContract), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.provider.SyncStateContract(@__env);
			}
		}
		protected SyncStateContract(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface Columns : BaseColumns
		{
		}

		public partial class Columns_
		{
			public static global::java.lang.Class _class
			{
				get { return __Columns.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __Columns : java.lang.Object, Columns
		{
			internal static global::java.lang.Class staticClass;
			static __Columns()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.SyncStateContract.__Columns), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.provider.SyncStateContract.__Columns(@__env);
				}
			}
			internal __Columns(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.provider.SyncStateContract.__Columns.staticClass = @__class;
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public static class ColumnsConstants 
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
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class Constants : java.lang.Object, Columns
		{
			internal static global::java.lang.Class staticClass;
			static Constants()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.SyncStateContract.Constants), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.provider.SyncStateContract.Constants(@__env);
				}
			}
			protected Constants(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _Constants6359;
			public Constants()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.provider.SyncStateContract.Constants.staticClass, global::android.provider.SyncStateContract.Constants._Constants6359, this);
			}
			public static global::java.lang.String CONTENT_DIRECTORY
			{
				get
				{
					return "syncstate";
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.provider.SyncStateContract.Constants.staticClass = @__class;
				global::android.provider.SyncStateContract.Constants._Constants6359 = @__env.GetMethodID(global::android.provider.SyncStateContract.Constants.staticClass, "<init>", "()V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class Helpers : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static Helpers()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.provider.SyncStateContract.Helpers), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.provider.SyncStateContract.Helpers(@__env);
				}
			}
			internal Helpers(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _get6360;
			public static byte[] get(android.content.ContentProviderClient arg0, android.net.Uri arg1, android.accounts.Account arg2) 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.provider.SyncStateContract.Helpers.staticClass, global::android.provider.SyncStateContract.Helpers._get6360, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _set6361;
			public static void set(android.content.ContentProviderClient arg0, android.net.Uri arg1, android.accounts.Account arg2, byte[] arg3) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.CallStaticVoidMethod(android.provider.SyncStateContract.Helpers.staticClass, global::android.provider.SyncStateContract.Helpers._set6361, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3));
			}
			internal static global::net.sf.jni4net.jni.MethodId _insert6362;
			public static global::android.net.Uri insert(android.content.ContentProviderClient arg0, android.net.Uri arg1, android.accounts.Account arg2, byte[] arg3) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.SyncStateContract.Helpers.staticClass, global::android.provider.SyncStateContract.Helpers._insert6362, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _update6363;
			public static void update(android.content.ContentProviderClient arg0, android.net.Uri arg1, byte[] arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.CallStaticVoidMethod(android.provider.SyncStateContract.Helpers.staticClass, global::android.provider.SyncStateContract.Helpers._update6363, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getWithUri6364;
			public static global::android.util.Pair getWithUri(android.content.ContentProviderClient arg0, android.net.Uri arg1, android.accounts.Account arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.Pair>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.SyncStateContract.Helpers.staticClass, global::android.provider.SyncStateContract.Helpers._getWithUri6364, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _newSetOperation6365;
			public static global::android.content.ContentProviderOperation newSetOperation(android.net.Uri arg0, android.accounts.Account arg1, byte[] arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.SyncStateContract.Helpers.staticClass, global::android.provider.SyncStateContract.Helpers._newSetOperation6365, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _newUpdateOperation6366;
			public static global::android.content.ContentProviderOperation newUpdateOperation(android.net.Uri arg0, byte[] arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.SyncStateContract.Helpers.staticClass, global::android.provider.SyncStateContract.Helpers._newUpdateOperation6366, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _Helpers6367;
			public Helpers()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.provider.SyncStateContract.Helpers.staticClass, global::android.provider.SyncStateContract.Helpers._Helpers6367, this);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.provider.SyncStateContract.Helpers.staticClass = @__class;
				global::android.provider.SyncStateContract.Helpers._get6360 = @__env.GetStaticMethodID(global::android.provider.SyncStateContract.Helpers.staticClass, "get", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Account;)[B");
				global::android.provider.SyncStateContract.Helpers._set6361 = @__env.GetStaticMethodID(global::android.provider.SyncStateContract.Helpers.staticClass, "set", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Account;[B)V");
				global::android.provider.SyncStateContract.Helpers._insert6362 = @__env.GetStaticMethodID(global::android.provider.SyncStateContract.Helpers.staticClass, "insert", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Account;[B)Landroid/net/Uri;");
				global::android.provider.SyncStateContract.Helpers._update6363 = @__env.GetStaticMethodID(global::android.provider.SyncStateContract.Helpers.staticClass, "update", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;[B)V");
				global::android.provider.SyncStateContract.Helpers._getWithUri6364 = @__env.GetStaticMethodID(global::android.provider.SyncStateContract.Helpers.staticClass, "getWithUri", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Account;)Landroid/util/Pair;");
				global::android.provider.SyncStateContract.Helpers._newSetOperation6365 = @__env.GetStaticMethodID(global::android.provider.SyncStateContract.Helpers.staticClass, "newSetOperation", "(Landroid/net/Uri;Landroid/accounts/Account;[B)Landroid/content/ContentProviderOperation;");
				global::android.provider.SyncStateContract.Helpers._newUpdateOperation6366 = @__env.GetStaticMethodID(global::android.provider.SyncStateContract.Helpers.staticClass, "newUpdateOperation", "(Landroid/net/Uri;[B)Landroid/content/ContentProviderOperation;");
				global::android.provider.SyncStateContract.Helpers._Helpers6367 = @__env.GetMethodID(global::android.provider.SyncStateContract.Helpers.staticClass, "<init>", "()V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _SyncStateContract6368;
		public SyncStateContract()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.provider.SyncStateContract.staticClass, global::android.provider.SyncStateContract._SyncStateContract6368, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.provider.SyncStateContract.staticClass = @__class;
			global::android.provider.SyncStateContract._SyncStateContract6368 = @__env.GetMethodID(global::android.provider.SyncStateContract.staticClass, "<init>", "()V");
		}
	}
}
