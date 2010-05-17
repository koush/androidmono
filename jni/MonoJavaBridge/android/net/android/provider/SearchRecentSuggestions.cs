namespace android.provider 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SearchRecentSuggestions : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static SearchRecentSuggestions() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.provider.SearchRecentSuggestions), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.provider.SearchRecentSuggestions(@__env); 
			} 
		} 
		protected SearchRecentSuggestions(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _truncateHistory6033; 
		protected virtual void truncateHistory(android.content.ContentResolver arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.provider.SearchRecentSuggestions)) 
				@__env.CallVoidMethod(this, _truncateHistory6033, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.provider.SearchRecentSuggestions.staticClass, _truncateHistory6033, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearHistory6034; 
		public virtual void clearHistory() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.provider.SearchRecentSuggestions)) 
				@__env.CallVoidMethod(this, _clearHistory6034); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.provider.SearchRecentSuggestions.staticClass, _clearHistory6034); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _saveRecentQuery6035; 
		public virtual void saveRecentQuery(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.provider.SearchRecentSuggestions)) 
				@__env.CallVoidMethod(this, _saveRecentQuery6035, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.provider.SearchRecentSuggestions.staticClass, _saveRecentQuery6035, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SearchRecentSuggestions6036; 
		public SearchRecentSuggestions(android.content.Context arg0, java.lang.String arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.provider.SearchRecentSuggestions.staticClass, _SearchRecentSuggestions6036, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _QUERIES_PROJECTION_1LINE6037; 
		public static java.lang.String[] QUERIES_PROJECTION_1LINE
		{ 
			get 
			{ 
				return default(java.lang.String[]); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _QUERIES_PROJECTION_2LINE6038; 
		public static java.lang.String[] QUERIES_PROJECTION_2LINE
		{ 
			get 
			{ 
				return default(java.lang.String[]); 
			} 
		} 
		public static int QUERIES_PROJECTION_DATE_INDEX
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int QUERIES_PROJECTION_QUERY_INDEX
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int QUERIES_PROJECTION_DISPLAY1_INDEX
		{ 
			get 
			{ 
				return 3; 
			} 
		} 
		public static int QUERIES_PROJECTION_DISPLAY2_INDEX
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.provider.SearchRecentSuggestions.staticClass = @__class; 
			global::android.provider.SearchRecentSuggestions._truncateHistory6033 = @__env.GetMethodID(global::android.provider.SearchRecentSuggestions.staticClass, "truncateHistory", "(Landroid/content/ContentResolver;I)V"); 
			global::android.provider.SearchRecentSuggestions._clearHistory6034 = @__env.GetMethodID(global::android.provider.SearchRecentSuggestions.staticClass, "clearHistory", "()V"); 
			global::android.provider.SearchRecentSuggestions._saveRecentQuery6035 = @__env.GetMethodID(global::android.provider.SearchRecentSuggestions.staticClass, "saveRecentQuery", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.provider.SearchRecentSuggestions._SearchRecentSuggestions6036 = @__env.GetMethodID(global::android.provider.SearchRecentSuggestions.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/String;I)V"); 
		} 
	} 
} 
