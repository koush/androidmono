namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SearchRecentSuggestionsProvider : android.content.ContentProvider
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SearchRecentSuggestionsProvider() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.SearchRecentSuggestionsProvider), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.SearchRecentSuggestionsProvider(@__env); 
			} 
		} 
		protected SearchRecentSuggestionsProvider(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getType1460; 
		public override java.lang.String getType(android.net.Uri arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SearchRecentSuggestionsProvider)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getType1460, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.SearchRecentSuggestionsProvider.staticClass, _getType1460, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _delete1461; 
		public override int delete(android.net.Uri arg0, java.lang.String arg1, java.lang.String[] arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SearchRecentSuggestionsProvider)) 
				return @__env.CallIntMethod(this, _delete1461, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.SearchRecentSuggestionsProvider.staticClass, _delete1461, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _insert1462; 
		public override android.net.Uri insert(android.net.Uri arg0, android.content.ContentValues arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SearchRecentSuggestionsProvider)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallObjectMethodPtr(this, _insert1462, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.SearchRecentSuggestionsProvider.staticClass, _insert1462, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _query1463; 
		public override android.database.Cursor query(android.net.Uri arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SearchRecentSuggestionsProvider)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, _query1463, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.SearchRecentSuggestionsProvider.staticClass, _query1463, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _update1464; 
		public override int update(android.net.Uri arg0, android.content.ContentValues arg1, java.lang.String arg2, java.lang.String[] arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SearchRecentSuggestionsProvider)) 
				return @__env.CallIntMethod(this, _update1464, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.SearchRecentSuggestionsProvider.staticClass, _update1464, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreate1465; 
		public override bool onCreate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SearchRecentSuggestionsProvider)) 
				return @__env.CallBooleanMethod(this, _onCreate1465); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.SearchRecentSuggestionsProvider.staticClass, _onCreate1465); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setupSuggestions1466; 
		protected virtual void setupSuggestions(java.lang.String arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SearchRecentSuggestionsProvider)) 
				@__env.CallVoidMethod(this, _setupSuggestions1466, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.SearchRecentSuggestionsProvider.staticClass, _setupSuggestions1466, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SearchRecentSuggestionsProvider1467; 
		public SearchRecentSuggestionsProvider()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.SearchRecentSuggestionsProvider.staticClass, _SearchRecentSuggestionsProvider1467, this); 
		} 
		public static int DATABASE_MODE_QUERIES
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int DATABASE_MODE_2LINES
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.SearchRecentSuggestionsProvider.staticClass = @__class; 
			global::android.content.SearchRecentSuggestionsProvider._getType1460 = @__env.GetMethodID(global::android.content.SearchRecentSuggestionsProvider.staticClass, "getType", "(Landroid/net/Uri;)Ljava/lang/String;"); 
			global::android.content.SearchRecentSuggestionsProvider._delete1461 = @__env.GetMethodID(global::android.content.SearchRecentSuggestionsProvider.staticClass, "delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I"); 
			global::android.content.SearchRecentSuggestionsProvider._insert1462 = @__env.GetMethodID(global::android.content.SearchRecentSuggestionsProvider.staticClass, "insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;"); 
			global::android.content.SearchRecentSuggestionsProvider._query1463 = @__env.GetMethodID(global::android.content.SearchRecentSuggestionsProvider.staticClass, "query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;"); 
			global::android.content.SearchRecentSuggestionsProvider._update1464 = @__env.GetMethodID(global::android.content.SearchRecentSuggestionsProvider.staticClass, "update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I"); 
			global::android.content.SearchRecentSuggestionsProvider._onCreate1465 = @__env.GetMethodID(global::android.content.SearchRecentSuggestionsProvider.staticClass, "onCreate", "()Z"); 
			global::android.content.SearchRecentSuggestionsProvider._setupSuggestions1466 = @__env.GetMethodID(global::android.content.SearchRecentSuggestionsProvider.staticClass, "setupSuggestions", "(Ljava/lang/String;I)V"); 
			global::android.content.SearchRecentSuggestionsProvider._SearchRecentSuggestionsProvider1467 = @__env.GetMethodID(global::android.content.SearchRecentSuggestionsProvider.staticClass, "<init>", "()V"); 
		} 
	} 
} 
