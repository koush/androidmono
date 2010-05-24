namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface SpinnerAdapter : Adapter
	{ 
		android.view.View getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2); 
	} 

	public partial class SpinnerAdapter_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __SpinnerAdapter.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __SpinnerAdapter : java.lang.Object, SpinnerAdapter
	{ 
		internal static global::java.lang.Class staticClass; 
		static __SpinnerAdapter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.__SpinnerAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.__SpinnerAdapter(@__env); 
			} 
		} 
		internal __SpinnerAdapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDropDownView10901; 
		 android.view.View android.widget.SpinnerAdapter.getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__SpinnerAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getDropDownView10901, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.__SpinnerAdapter.staticClass, _getDropDownView10901, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty10902; 
		 bool android.widget.Adapter.isEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__SpinnerAdapter)) 
				return @__env.CallBooleanMethod(this, _isEmpty10902); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.__SpinnerAdapter.staticClass, _isEmpty10902); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCount10903; 
		 int android.widget.Adapter.getCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__SpinnerAdapter)) 
				return @__env.CallIntMethod(this, _getCount10903); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.__SpinnerAdapter.staticClass, _getCount10903); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerDataSetObserver10904; 
		 void android.widget.Adapter.registerDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__SpinnerAdapter)) 
				@__env.CallVoidMethod(this, _registerDataSetObserver10904, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.__SpinnerAdapter.staticClass, _registerDataSetObserver10904, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterDataSetObserver10905; 
		 void android.widget.Adapter.unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__SpinnerAdapter)) 
				@__env.CallVoidMethod(this, _unregisterDataSetObserver10905, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.__SpinnerAdapter.staticClass, _unregisterDataSetObserver10905, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItem10906; 
		 java.lang.Object android.widget.Adapter.getItem(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__SpinnerAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _getItem10906, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.__SpinnerAdapter.staticClass, _getItem10906, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItemId10907; 
		 long android.widget.Adapter.getItemId(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__SpinnerAdapter)) 
				return @__env.CallLongMethod(this, _getItemId10907, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.widget.__SpinnerAdapter.staticClass, _getItemId10907, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasStableIds10908; 
		 bool android.widget.Adapter.hasStableIds() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__SpinnerAdapter)) 
				return @__env.CallBooleanMethod(this, _hasStableIds10908); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.__SpinnerAdapter.staticClass, _hasStableIds10908); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getView10909; 
		 android.view.View android.widget.Adapter.getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__SpinnerAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getView10909, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.__SpinnerAdapter.staticClass, _getView10909, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getItemViewType10910; 
		 int android.widget.Adapter.getItemViewType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__SpinnerAdapter)) 
				return @__env.CallIntMethod(this, _getItemViewType10910, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.__SpinnerAdapter.staticClass, _getItemViewType10910, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getViewTypeCount10911; 
		 int android.widget.Adapter.getViewTypeCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.__SpinnerAdapter)) 
				return @__env.CallIntMethod(this, _getViewTypeCount10911); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.__SpinnerAdapter.staticClass, _getViewTypeCount10911); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.__SpinnerAdapter.staticClass = @__class; 
			global::android.widget.__SpinnerAdapter._getDropDownView10901 = @__env.GetMethodID(global::android.widget.__SpinnerAdapter.staticClass, "android.widget.SpinnerAdapter.getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.__SpinnerAdapter._isEmpty10902 = @__env.GetMethodID(global::android.widget.__SpinnerAdapter.staticClass, "android.widget.Adapter.isEmpty", "()Z"); 
			global::android.widget.__SpinnerAdapter._getCount10903 = @__env.GetMethodID(global::android.widget.__SpinnerAdapter.staticClass, "android.widget.Adapter.getCount", "()I"); 
			global::android.widget.__SpinnerAdapter._registerDataSetObserver10904 = @__env.GetMethodID(global::android.widget.__SpinnerAdapter.staticClass, "android.widget.Adapter.registerDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.widget.__SpinnerAdapter._unregisterDataSetObserver10905 = @__env.GetMethodID(global::android.widget.__SpinnerAdapter.staticClass, "android.widget.Adapter.unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.widget.__SpinnerAdapter._getItem10906 = @__env.GetMethodID(global::android.widget.__SpinnerAdapter.staticClass, "android.widget.Adapter.getItem", "(I)Ljava/lang/Object;"); 
			global::android.widget.__SpinnerAdapter._getItemId10907 = @__env.GetMethodID(global::android.widget.__SpinnerAdapter.staticClass, "android.widget.Adapter.getItemId", "(I)J"); 
			global::android.widget.__SpinnerAdapter._hasStableIds10908 = @__env.GetMethodID(global::android.widget.__SpinnerAdapter.staticClass, "android.widget.Adapter.hasStableIds", "()Z"); 
			global::android.widget.__SpinnerAdapter._getView10909 = @__env.GetMethodID(global::android.widget.__SpinnerAdapter.staticClass, "android.widget.Adapter.getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"); 
			global::android.widget.__SpinnerAdapter._getItemViewType10910 = @__env.GetMethodID(global::android.widget.__SpinnerAdapter.staticClass, "android.widget.Adapter.getItemViewType", "(I)I"); 
			global::android.widget.__SpinnerAdapter._getViewTypeCount10911 = @__env.GetMethodID(global::android.widget.__SpinnerAdapter.staticClass, "android.widget.Adapter.getViewTypeCount", "()I"); 
		} 
	} 
} 
