namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface Adapter 
	{ 
		bool isEmpty(); 
		int getCount(); 
		void registerDataSetObserver(android.database.DataSetObserver arg0); 
		void unregisterDataSetObserver(android.database.DataSetObserver arg0); 
		global::java.lang.Object getItem(int arg0); 
		long getItemId(int arg0); 
		bool hasStableIds(); 
		global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2); 
		int getItemViewType(int arg0); 
		int getViewTypeCount(); 
	} 

	public partial class Adapter_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __Adapter.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __Adapter : java.lang.Object, Adapter
	{ 
		internal static global::java.lang.Class staticClass; 
		static __Adapter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.__Adapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.__Adapter(@__env); 
			} 
		} 
		internal __Adapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty9790; 
		 bool android.widget.Adapter.isEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__Adapter)) 
				return @__env.CallBooleanMethod(this, global::android.widget.__Adapter._isEmpty9790); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.__Adapter.staticClass, global::android.widget.__Adapter._isEmpty9790); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCount9791; 
		 int android.widget.Adapter.getCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__Adapter)) 
				return @__env.CallIntMethod(this, global::android.widget.__Adapter._getCount9791); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.__Adapter.staticClass, global::android.widget.__Adapter._getCount9791); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerDataSetObserver9792; 
		 void android.widget.Adapter.registerDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__Adapter)) 
				@__env.CallVoidMethod(this, global::android.widget.__Adapter._registerDataSetObserver9792, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.__Adapter.staticClass, global::android.widget.__Adapter._registerDataSetObserver9792, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterDataSetObserver9793; 
		 void android.widget.Adapter.unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__Adapter)) 
				@__env.CallVoidMethod(this, global::android.widget.__Adapter._unregisterDataSetObserver9793, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.__Adapter.staticClass, global::android.widget.__Adapter._unregisterDataSetObserver9793, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItem9794; 
		 global::java.lang.Object android.widget.Adapter.getItem(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__Adapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.__Adapter._getItem9794, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.__Adapter.staticClass, global::android.widget.__Adapter._getItem9794, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItemId9795; 
		 long android.widget.Adapter.getItemId(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__Adapter)) 
				return @__env.CallLongMethod(this, global::android.widget.__Adapter._getItemId9795, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.__Adapter.staticClass, global::android.widget.__Adapter._getItemId9795, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasStableIds9796; 
		 bool android.widget.Adapter.hasStableIds() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__Adapter)) 
				return @__env.CallBooleanMethod(this, global::android.widget.__Adapter._hasStableIds9796); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.__Adapter.staticClass, global::android.widget.__Adapter._hasStableIds9796); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getView9797; 
		 global::android.view.View android.widget.Adapter.getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__Adapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.__Adapter._getView9797, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.__Adapter.staticClass, global::android.widget.__Adapter._getView9797, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItemViewType9798; 
		 int android.widget.Adapter.getItemViewType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__Adapter)) 
				return @__env.CallIntMethod(this, global::android.widget.__Adapter._getItemViewType9798, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.__Adapter.staticClass, global::android.widget.__Adapter._getItemViewType9798, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getViewTypeCount9799; 
		 int android.widget.Adapter.getViewTypeCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__Adapter)) 
				return @__env.CallIntMethod(this, global::android.widget.__Adapter._getViewTypeCount9799); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.__Adapter.staticClass, global::android.widget.__Adapter._getViewTypeCount9799); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.__Adapter.staticClass = @__class; 
			global::android.widget.__Adapter._isEmpty9790 = @__env.GetMethodID(global::android.widget.__Adapter.staticClass, "android.widget.Adapter.isEmpty", "()Z"); 
			global::android.widget.__Adapter._getCount9791 = @__env.GetMethodID(global::android.widget.__Adapter.staticClass, "android.widget.Adapter.getCount", "()I"); 
			global::android.widget.__Adapter._registerDataSetObserver9792 = @__env.GetMethodID(global::android.widget.__Adapter.staticClass, "android.widget.Adapter.registerDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.widget.__Adapter._unregisterDataSetObserver9793 = @__env.GetMethodID(global::android.widget.__Adapter.staticClass, "android.widget.Adapter.unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.widget.__Adapter._getItem9794 = @__env.GetMethodID(global::android.widget.__Adapter.staticClass, "android.widget.Adapter.getItem", "(I)Ljava/lang/Object;"); 
			global::android.widget.__Adapter._getItemId9795 = @__env.GetMethodID(global::android.widget.__Adapter.staticClass, "android.widget.Adapter.getItemId", "(I)J"); 
			global::android.widget.__Adapter._hasStableIds9796 = @__env.GetMethodID(global::android.widget.__Adapter.staticClass, "android.widget.Adapter.hasStableIds", "()Z"); 
			global::android.widget.__Adapter._getView9797 = @__env.GetMethodID(global::android.widget.__Adapter.staticClass, "android.widget.Adapter.getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.__Adapter._getItemViewType9798 = @__env.GetMethodID(global::android.widget.__Adapter.staticClass, "android.widget.Adapter.getItemViewType", "(I)I"); 
			global::android.widget.__Adapter._getViewTypeCount9799 = @__env.GetMethodID(global::android.widget.__Adapter.staticClass, "android.widget.Adapter.getViewTypeCount", "()I"); 
		} 
	} 
} 
