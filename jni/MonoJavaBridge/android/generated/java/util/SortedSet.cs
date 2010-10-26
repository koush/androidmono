namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.SortedSet_))]
	public partial interface SortedSet : Set
	{
		global::java.lang.Object last();
		global::java.lang.Object first();
		global::java.util.Comparator comparator();
		global::java.util.SortedSet subSet(java.lang.Object arg0, java.lang.Object arg1);
		global::java.util.SortedSet headSet(java.lang.Object arg0);
		global::java.util.SortedSet tailSet(java.lang.Object arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.SortedSet))]
	internal sealed partial class SortedSet_ : java.lang.Object, SortedSet
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SortedSet_()
		{
			InitJNI();
		}
		internal SortedSet_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _last26781;
		 global::java.lang.Object java.util.SortedSet.last() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._last26781)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._last26781)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _first26782;
		 global::java.lang.Object java.util.SortedSet.first() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._first26782)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._first26782)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _comparator26783;
		 global::java.util.Comparator java.util.SortedSet.comparator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._comparator26783)) as java.util.Comparator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._comparator26783)) as java.util.Comparator;
		}
		internal static global::MonoJavaBridge.MethodId _subSet26784;
		 global::java.util.SortedSet java.util.SortedSet.subSet(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._subSet26784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.SortedSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._subSet26784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.SortedSet;
		}
		internal static global::MonoJavaBridge.MethodId _headSet26785;
		 global::java.util.SortedSet java.util.SortedSet.headSet(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._headSet26785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._headSet26785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedSet;
		}
		internal static global::MonoJavaBridge.MethodId _tailSet26786;
		 global::java.util.SortedSet java.util.SortedSet.tailSet(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._tailSet26786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._tailSet26786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedSet;
		}
		internal static global::MonoJavaBridge.MethodId _add26787;
		 bool java.util.Set.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._add26787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._add26787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals26788;
		 bool java.util.Set.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._equals26788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._equals26788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26789;
		 int java.util.Set.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.SortedSet_._hashCode26789);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._hashCode26789);
		}
		internal static global::MonoJavaBridge.MethodId _clear26790;
		 void java.util.Set.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.SortedSet_._clear26790);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._clear26790);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26791;
		 bool java.util.Set.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._isEmpty26791);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._isEmpty26791);
		}
		internal static global::MonoJavaBridge.MethodId _contains26792;
		 bool java.util.Set.contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._contains26792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._contains26792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26793;
		 bool java.util.Set.addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._addAll26793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._addAll26793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size26794;
		 int java.util.Set.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.SortedSet_._size26794);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._size26794);
		}
		internal static global::MonoJavaBridge.MethodId _toArray26795;
		 global::java.lang.Object[] java.util.Set.toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._toArray26795)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._toArray26795)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray26796;
		 global::java.lang.Object[] java.util.Set.toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._toArray26796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._toArray26796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator26797;
		 global::java.util.Iterator java.util.Set.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._iterator26797)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._iterator26797)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove26798;
		 bool java.util.Set.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._remove26798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._remove26798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll26799;
		 bool java.util.Set.containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._containsAll26799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._containsAll26799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll26800;
		 bool java.util.Set.removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._removeAll26800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._removeAll26800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll26801;
		 bool java.util.Set.retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._retainAll26801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._retainAll26801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _add26802;
		 bool java.util.Collection.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._add26802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._add26802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals26803;
		 bool java.util.Collection.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._equals26803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._equals26803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26804;
		 int java.util.Collection.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.SortedSet_._hashCode26804);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._hashCode26804);
		}
		internal static global::MonoJavaBridge.MethodId _clear26805;
		 void java.util.Collection.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.SortedSet_._clear26805);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._clear26805);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26806;
		 bool java.util.Collection.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._isEmpty26806);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._isEmpty26806);
		}
		internal static global::MonoJavaBridge.MethodId _contains26807;
		 bool java.util.Collection.contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._contains26807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._contains26807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26808;
		 bool java.util.Collection.addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._addAll26808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._addAll26808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size26809;
		 int java.util.Collection.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.SortedSet_._size26809);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._size26809);
		}
		internal static global::MonoJavaBridge.MethodId _toArray26810;
		 global::java.lang.Object[] java.util.Collection.toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._toArray26810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._toArray26810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray26811;
		 global::java.lang.Object[] java.util.Collection.toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._toArray26811)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._toArray26811)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator26812;
		 global::java.util.Iterator java.util.Collection.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._iterator26812)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._iterator26812)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove26813;
		 bool java.util.Collection.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._remove26813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._remove26813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll26814;
		 bool java.util.Collection.containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._containsAll26814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._containsAll26814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll26815;
		 bool java.util.Collection.removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._removeAll26815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._removeAll26815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll26816;
		 bool java.util.Collection.retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._retainAll26816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._retainAll26816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(((global::java.lang.Iterable)this).iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator26817;
		 global::java.util.Iterator java.lang.Iterable.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._iterator26817)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._iterator26817)) as java.util.Iterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.SortedSet_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/SortedSet"));
			global::java.util.SortedSet_._last26781 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "last", "()Ljava/lang/Object;");
			global::java.util.SortedSet_._first26782 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "first", "()Ljava/lang/Object;");
			global::java.util.SortedSet_._comparator26783 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "comparator", "()Ljava/util/Comparator;");
			global::java.util.SortedSet_._subSet26784 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "subSet", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedSet;");
			global::java.util.SortedSet_._headSet26785 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "headSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;");
			global::java.util.SortedSet_._tailSet26786 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "tailSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;");
			global::java.util.SortedSet_._add26787 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.SortedSet_._equals26788 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.SortedSet_._hashCode26789 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "hashCode", "()I");
			global::java.util.SortedSet_._clear26790 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "clear", "()V");
			global::java.util.SortedSet_._isEmpty26791 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "isEmpty", "()Z");
			global::java.util.SortedSet_._contains26792 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.SortedSet_._addAll26793 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.SortedSet_._size26794 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "size", "()I");
			global::java.util.SortedSet_._toArray26795 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.SortedSet_._toArray26796 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.SortedSet_._iterator26797 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.SortedSet_._remove26798 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.SortedSet_._containsAll26799 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.SortedSet_._removeAll26800 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.SortedSet_._retainAll26801 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.SortedSet_._add26802 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.SortedSet_._equals26803 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.SortedSet_._hashCode26804 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "hashCode", "()I");
			global::java.util.SortedSet_._clear26805 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "clear", "()V");
			global::java.util.SortedSet_._isEmpty26806 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "isEmpty", "()Z");
			global::java.util.SortedSet_._contains26807 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.SortedSet_._addAll26808 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.SortedSet_._size26809 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "size", "()I");
			global::java.util.SortedSet_._toArray26810 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.SortedSet_._toArray26811 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.SortedSet_._iterator26812 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.SortedSet_._remove26813 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.SortedSet_._containsAll26814 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.SortedSet_._removeAll26815 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.SortedSet_._retainAll26816 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.SortedSet_._iterator26817 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "iterator", "()Ljava/util/Iterator;");
		}
	}
}
