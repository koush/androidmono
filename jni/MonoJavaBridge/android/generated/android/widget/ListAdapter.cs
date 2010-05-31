namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface ListAdapter : Adapter
	{
		bool isEnabled(int arg0);
		bool areAllItemsEnabled();
	}

	public partial class ListAdapter_
	{
		public static global::java.lang.Class _class
		{
			get { return __ListAdapter.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __ListAdapter : java.lang.Object, ListAdapter
	{
		internal static global::java.lang.Class staticClass;
		static __ListAdapter()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.__ListAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.__ListAdapter(@__env);
			}
		}
		internal __ListAdapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEnabled10425;
		 bool android.widget.ListAdapter.isEnabled(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.__ListAdapter._isEnabled10425, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.__ListAdapter.staticClass, global::android.widget.__ListAdapter._isEnabled10425, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _areAllItemsEnabled10426;
		 bool android.widget.ListAdapter.areAllItemsEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.__ListAdapter._areAllItemsEnabled10426);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.__ListAdapter.staticClass, global::android.widget.__ListAdapter._areAllItemsEnabled10426);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty10427;
		 bool android.widget.Adapter.isEmpty() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.__ListAdapter._isEmpty10427);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.__ListAdapter.staticClass, global::android.widget.__ListAdapter._isEmpty10427);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCount10428;
		 int android.widget.Adapter.getCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.__ListAdapter._getCount10428);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.__ListAdapter.staticClass, global::android.widget.__ListAdapter._getCount10428);
		}
		internal static global::net.sf.jni4net.jni.MethodId _registerDataSetObserver10429;
		 void android.widget.Adapter.registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.__ListAdapter._registerDataSetObserver10429, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.__ListAdapter.staticClass, global::android.widget.__ListAdapter._registerDataSetObserver10429, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unregisterDataSetObserver10430;
		 void android.widget.Adapter.unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.__ListAdapter._unregisterDataSetObserver10430, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.__ListAdapter.staticClass, global::android.widget.__ListAdapter._unregisterDataSetObserver10430, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItem10431;
		 global::java.lang.Object android.widget.Adapter.getItem(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.__ListAdapter._getItem10431, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.__ListAdapter.staticClass, global::android.widget.__ListAdapter._getItem10431, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItemId10432;
		 long android.widget.Adapter.getItemId(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.widget.__ListAdapter._getItemId10432, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.__ListAdapter.staticClass, global::android.widget.__ListAdapter._getItemId10432, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasStableIds10433;
		 bool android.widget.Adapter.hasStableIds() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.__ListAdapter._hasStableIds10433);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.__ListAdapter.staticClass, global::android.widget.__ListAdapter._hasStableIds10433);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getView10434;
		 global::android.view.View android.widget.Adapter.getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.__ListAdapter._getView10434, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.__ListAdapter.staticClass, global::android.widget.__ListAdapter._getView10434, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItemViewType10435;
		 int android.widget.Adapter.getItemViewType(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.__ListAdapter._getItemViewType10435, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.__ListAdapter.staticClass, global::android.widget.__ListAdapter._getItemViewType10435, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getViewTypeCount10436;
		 int android.widget.Adapter.getViewTypeCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.__ListAdapter._getViewTypeCount10436);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.__ListAdapter.staticClass, global::android.widget.__ListAdapter._getViewTypeCount10436);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.__ListAdapter.staticClass = @__class;
			global::android.widget.__ListAdapter._isEnabled10425 = @__env.GetMethodID(global::android.widget.__ListAdapter.staticClass, "android.widget.ListAdapter.isEnabled", "(I)Z");
			global::android.widget.__ListAdapter._areAllItemsEnabled10426 = @__env.GetMethodID(global::android.widget.__ListAdapter.staticClass, "android.widget.ListAdapter.areAllItemsEnabled", "()Z");
			global::android.widget.__ListAdapter._isEmpty10427 = @__env.GetMethodID(global::android.widget.__ListAdapter.staticClass, "android.widget.Adapter.isEmpty", "()Z");
			global::android.widget.__ListAdapter._getCount10428 = @__env.GetMethodID(global::android.widget.__ListAdapter.staticClass, "android.widget.Adapter.getCount", "()I");
			global::android.widget.__ListAdapter._registerDataSetObserver10429 = @__env.GetMethodID(global::android.widget.__ListAdapter.staticClass, "android.widget.Adapter.registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.__ListAdapter._unregisterDataSetObserver10430 = @__env.GetMethodID(global::android.widget.__ListAdapter.staticClass, "android.widget.Adapter.unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.__ListAdapter._getItem10431 = @__env.GetMethodID(global::android.widget.__ListAdapter.staticClass, "android.widget.Adapter.getItem", "(I)Ljava/lang/Object;");
			global::android.widget.__ListAdapter._getItemId10432 = @__env.GetMethodID(global::android.widget.__ListAdapter.staticClass, "android.widget.Adapter.getItemId", "(I)J");
			global::android.widget.__ListAdapter._hasStableIds10433 = @__env.GetMethodID(global::android.widget.__ListAdapter.staticClass, "android.widget.Adapter.hasStableIds", "()Z");
			global::android.widget.__ListAdapter._getView10434 = @__env.GetMethodID(global::android.widget.__ListAdapter.staticClass, "android.widget.Adapter.getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.__ListAdapter._getItemViewType10435 = @__env.GetMethodID(global::android.widget.__ListAdapter.staticClass, "android.widget.Adapter.getItemViewType", "(I)I");
			global::android.widget.__ListAdapter._getViewTypeCount10436 = @__env.GetMethodID(global::android.widget.__ListAdapter.staticClass, "android.widget.Adapter.getViewTypeCount", "()I");
		}
	}
}
