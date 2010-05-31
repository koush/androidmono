namespace android.database.sqlite 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface SQLiteTransactionListener 
	{ 
		void onBegin(); 
		void onCommit(); 
		void onRollback(); 
	} 

	public partial class SQLiteTransactionListener_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __SQLiteTransactionListener.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __SQLiteTransactionListener : java.lang.Object, SQLiteTransactionListener
	{ 
		internal static global::java.lang.Class staticClass; 
		static __SQLiteTransactionListener() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.sqlite.__SQLiteTransactionListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.database.sqlite.__SQLiteTransactionListener(@__env); 
			} 
		} 
		internal __SQLiteTransactionListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBegin2572; 
		 void android.database.sqlite.SQLiteTransactionListener.onBegin() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.database.sqlite.__SQLiteTransactionListener._onBegin2572); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.__SQLiteTransactionListener.staticClass, global::android.database.sqlite.__SQLiteTransactionListener._onBegin2572); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCommit2573; 
		 void android.database.sqlite.SQLiteTransactionListener.onCommit() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.database.sqlite.__SQLiteTransactionListener._onCommit2573); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.__SQLiteTransactionListener.staticClass, global::android.database.sqlite.__SQLiteTransactionListener._onCommit2573); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRollback2574; 
		 void android.database.sqlite.SQLiteTransactionListener.onRollback() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.database.sqlite.__SQLiteTransactionListener._onRollback2574); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.__SQLiteTransactionListener.staticClass, global::android.database.sqlite.__SQLiteTransactionListener._onRollback2574); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.sqlite.__SQLiteTransactionListener.staticClass = @__class; 
			global::android.database.sqlite.__SQLiteTransactionListener._onBegin2572 = @__env.GetMethodID(global::android.database.sqlite.__SQLiteTransactionListener.staticClass, "android.database.sqlite.SQLiteTransactionListener.onBegin", "()V"); 
			global::android.database.sqlite.__SQLiteTransactionListener._onCommit2573 = @__env.GetMethodID(global::android.database.sqlite.__SQLiteTransactionListener.staticClass, "android.database.sqlite.SQLiteTransactionListener.onCommit", "()V"); 
			global::android.database.sqlite.__SQLiteTransactionListener._onRollback2574 = @__env.GetMethodID(global::android.database.sqlite.__SQLiteTransactionListener.staticClass, "android.database.sqlite.SQLiteTransactionListener.onRollback", "()V"); 
		} 
	} 
} 
