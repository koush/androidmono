namespace android.provider 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SyncStateContract : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static SyncStateContract() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.SyncStateContract), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public static class ColumnsConstants 
		{ 
			public static java.lang.String ACCOUNT_NAME
			{ 
				get 
				{ 
					return "account_name"; 
				} 
			} 
			public static java.lang.String ACCOUNT_TYPE
			{ 
				get 
				{ 
					return "account_type"; 
				} 
			} 
			public static java.lang.String DATA
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.SyncStateContract.Constants), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _Constants6080; 
			public Constants()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.provider.SyncStateContract.Constants.staticClass, _Constants6080, this); 
			} 
			public static java.lang.String CONTENT_DIRECTORY
			{ 
				get 
				{ 
					return "syncstate"; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.SyncStateContract.Constants.staticClass = @__class; 
				global::android.provider.SyncStateContract.Constants._Constants6080 = @__env.GetMethodID(global::android.provider.SyncStateContract.Constants.staticClass, "<init>", "()V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Helpers : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static Helpers() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.SyncStateContract.Helpers), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _get6081; 
			public static byte[] get(android.content.ContentProviderClient arg0, android.net.Uri arg1, android.accounts.Account arg2) 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.provider.SyncStateContract.Helpers.staticClass, _get6081, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _set6082; 
			public static void set(android.content.ContentProviderClient arg0, android.net.Uri arg1, android.accounts.Account arg2, byte[] arg3) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.CallStaticVoidMethod(android.provider.SyncStateContract.Helpers.staticClass, _set6082, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _insert6083; 
			public static android.net.Uri insert(android.content.ContentProviderClient arg0, android.net.Uri arg1, android.accounts.Account arg2, byte[] arg3) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.SyncStateContract.Helpers.staticClass, _insert6083, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _update6084; 
			public static void update(android.content.ContentProviderClient arg0, android.net.Uri arg1, byte[] arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.CallStaticVoidMethod(android.provider.SyncStateContract.Helpers.staticClass, _update6084, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getWithUri6085; 
			public static android.util.Pair getWithUri(android.content.ContentProviderClient arg0, android.net.Uri arg1, android.accounts.Account arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.Pair>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.SyncStateContract.Helpers.staticClass, _getWithUri6085, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _newSetOperation6086; 
			public static android.content.ContentProviderOperation newSetOperation(android.net.Uri arg0, android.accounts.Account arg1, byte[] arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.SyncStateContract.Helpers.staticClass, _newSetOperation6086, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _newUpdateOperation6087; 
			public static android.content.ContentProviderOperation newUpdateOperation(android.net.Uri arg0, byte[] arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation>(@__env, @__env.CallStaticObjectMethodPtr(android.provider.SyncStateContract.Helpers.staticClass, _newUpdateOperation6087, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _Helpers6088; 
			public Helpers()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.provider.SyncStateContract.Helpers.staticClass, _Helpers6088, this); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.provider.SyncStateContract.Helpers.staticClass = @__class; 
				global::android.provider.SyncStateContract.Helpers._get6081 = @__env.GetStaticMethodID(global::android.provider.SyncStateContract.Helpers.staticClass, "get", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Account;)[B"); 
				global::android.provider.SyncStateContract.Helpers._set6082 = @__env.GetStaticMethodID(global::android.provider.SyncStateContract.Helpers.staticClass, "set", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Account;[B)V"); 
				global::android.provider.SyncStateContract.Helpers._insert6083 = @__env.GetStaticMethodID(global::android.provider.SyncStateContract.Helpers.staticClass, "insert", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Account;[B)Landroid/net/Uri;"); 
				global::android.provider.SyncStateContract.Helpers._update6084 = @__env.GetStaticMethodID(global::android.provider.SyncStateContract.Helpers.staticClass, "update", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;[B)V"); 
				global::android.provider.SyncStateContract.Helpers._getWithUri6085 = @__env.GetStaticMethodID(global::android.provider.SyncStateContract.Helpers.staticClass, "getWithUri", "(Landroid/content/ContentProviderClient;Landroid/net/Uri;Landroid/accounts/Account;)Landroid/util/Pair;"); 
				global::android.provider.SyncStateContract.Helpers._newSetOperation6086 = @__env.GetStaticMethodID(global::android.provider.SyncStateContract.Helpers.staticClass, "newSetOperation", "(Landroid/net/Uri;Landroid/accounts/Account;[B)Landroid/content/ContentProviderOperation;"); 
				global::android.provider.SyncStateContract.Helpers._newUpdateOperation6087 = @__env.GetStaticMethodID(global::android.provider.SyncStateContract.Helpers.staticClass, "newUpdateOperation", "(Landroid/net/Uri;[B)Landroid/content/ContentProviderOperation;"); 
				global::android.provider.SyncStateContract.Helpers._Helpers6088 = @__env.GetMethodID(global::android.provider.SyncStateContract.Helpers.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SyncStateContract6089; 
		public SyncStateContract()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.provider.SyncStateContract.staticClass, _SyncStateContract6089, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.provider.SyncStateContract.staticClass = @__class; 
			global::android.provider.SyncStateContract._SyncStateContract6089 = @__env.GetMethodID(global::android.provider.SyncStateContract.staticClass, "<init>", "()V"); 
		} 
	} 
} 
