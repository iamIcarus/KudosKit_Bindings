using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ironsrc.Kudoskit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']"
	[global::Android.Runtime.Register ("com/ironsrc/kudoskit/KudosKit", DoNotGenerateAcw=true)]
	public partial class KudosKit : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/field[@name='BUNDLE_INTERNAL']"
		[Register ("BUNDLE_INTERNAL")]
		protected const string BundleInternal = (string) "internal";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/field[@name='BUNDLE_INTERNAL_CONFIG']"
		[Register ("BUNDLE_INTERNAL_CONFIG")]
		protected const string BundleInternalConfig = (string) "{\"orientations\": [\"portrait\", \"landscape\"]}";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/field[@name='BUNDLE_NORMAL']"
		[Register ("BUNDLE_NORMAL")]
		protected const string BundleNormal = (string) "normal";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/field[@name='START_ALWAYS']"
		[Register ("START_ALWAYS")]
		public const int StartAlways = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/field[@name='START_IF_READY']"
		[Register ("START_IF_READY")]
		public const int StartIfReady = (int) 0;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit.Bundle']"
		[global::Android.Runtime.Register ("com/ironsrc/kudoskit/KudosKit$Bundle", DoNotGenerateAcw=true)]
		public partial class Bundle : global::Java.Lang.Object {


			static IntPtr config_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit.Bundle']/field[@name='config']"
			[Register ("config")]
			public string Config {
				get {
					if (config_jfieldId == IntPtr.Zero)
						config_jfieldId = JNIEnv.GetFieldID (class_ref, "config", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, config_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (config_jfieldId == IntPtr.Zero)
						config_jfieldId = JNIEnv.GetFieldID (class_ref, "config", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					JNIEnv.SetField (Handle, config_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr url_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit.Bundle']/field[@name='url']"
			[Register ("url")]
			public string Url {
				get {
					if (url_jfieldId == IntPtr.Zero)
						url_jfieldId = JNIEnv.GetFieldID (class_ref, "url", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, url_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (url_jfieldId == IntPtr.Zero)
						url_jfieldId = JNIEnv.GetFieldID (class_ref, "url", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					JNIEnv.SetField (Handle, url_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ironsrc/kudoskit/KudosKit$Bundle", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Bundle); }
			}

			protected Bundle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_ironsrc_kudoskit_KudosKit_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit.Bundle']/constructor[@name='KudosKit.Bundle' and count(parameter)=3 and parameter[1][@type='com.ironsrc.kudoskit.KudosKit'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/ironsrc/kudoskit/KudosKit;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public Bundle (global::Com.Ironsrc.Kudoskit.KudosKit __self, string p1, string p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);;
				IntPtr native_p2 = JNIEnv.NewString (p2);;
				if (GetType () != typeof (Bundle)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", new JValue (__self), new JValue (native_p1), new JValue (native_p2)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", new JValue (__self), new JValue (native_p1), new JValue (native_p2));
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
					return;
				}

				if (id_ctor_Lcom_ironsrc_kudoskit_KudosKit_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_ironsrc_kudoskit_KudosKit_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/ironsrc/kudoskit/KudosKit;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_ironsrc_kudoskit_KudosKit_Ljava_lang_String_Ljava_lang_String_, new JValue (__self), new JValue (native_p1), new JValue (native_p2)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_ironsrc_kudoskit_KudosKit_Ljava_lang_String_Ljava_lang_String_, new JValue (__self), new JValue (native_p1), new JValue (native_p2));
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit.DeviceDimensions']"
		[global::Android.Runtime.Register ("com/ironsrc/kudoskit/KudosKit$DeviceDimensions", DoNotGenerateAcw=true)]
		public partial class DeviceDimensions : global::Java.Lang.Object {


			static IntPtr height_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit.DeviceDimensions']/field[@name='height']"
			[Register ("height")]
			public float Height {
				get {
					if (height_jfieldId == IntPtr.Zero)
						height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "F");
					return JNIEnv.GetFloatField (Handle, height_jfieldId);
				}
				set {
					if (height_jfieldId == IntPtr.Zero)
						height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "F");
					JNIEnv.SetField (Handle, height_jfieldId, value);
				}
			}

			static IntPtr scale_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit.DeviceDimensions']/field[@name='scale']"
			[Register ("scale")]
			public float Scale {
				get {
					if (scale_jfieldId == IntPtr.Zero)
						scale_jfieldId = JNIEnv.GetFieldID (class_ref, "scale", "F");
					return JNIEnv.GetFloatField (Handle, scale_jfieldId);
				}
				set {
					if (scale_jfieldId == IntPtr.Zero)
						scale_jfieldId = JNIEnv.GetFieldID (class_ref, "scale", "F");
					JNIEnv.SetField (Handle, scale_jfieldId, value);
				}
			}

			static IntPtr width_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit.DeviceDimensions']/field[@name='width']"
			[Register ("width")]
			public float Width {
				get {
					if (width_jfieldId == IntPtr.Zero)
						width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "F");
					return JNIEnv.GetFloatField (Handle, width_jfieldId);
				}
				set {
					if (width_jfieldId == IntPtr.Zero)
						width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "F");
					JNIEnv.SetField (Handle, width_jfieldId, value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ironsrc/kudoskit/KudosKit$DeviceDimensions", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DeviceDimensions); }
			}

			protected DeviceDimensions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit.EventId']"
		[global::Android.Runtime.Register ("com/ironsrc/kudoskit/KudosKit$EventId", DoNotGenerateAcw=true)]
		public sealed partial class EventId : global::Java.Lang.Enum {


			static IntPtr EVENT_INAPP_ITEMS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit.EventId']/field[@name='EVENT_INAPP_ITEMS']"
			[Register ("EVENT_INAPP_ITEMS")]
			public static global::Com.Ironsrc.Kudoskit.KudosKit.EventId EventInappItems {
				get {
					if (EVENT_INAPP_ITEMS_jfieldId == IntPtr.Zero)
						EVENT_INAPP_ITEMS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT_INAPP_ITEMS", "Lcom/ironsrc/kudoskit/KudosKit$EventId;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EVENT_INAPP_ITEMS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit.EventId> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EVENT_INAPP_ITEMS_jfieldId == IntPtr.Zero)
						EVENT_INAPP_ITEMS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT_INAPP_ITEMS", "Lcom/ironsrc/kudoskit/KudosKit$EventId;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EVENT_INAPP_ITEMS_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EVENT_PRELOADED_RIGHTSPOTS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit.EventId']/field[@name='EVENT_PRELOADED_RIGHTSPOTS']"
			[Register ("EVENT_PRELOADED_RIGHTSPOTS")]
			public static global::Com.Ironsrc.Kudoskit.KudosKit.EventId EventPreloadedRightspots {
				get {
					if (EVENT_PRELOADED_RIGHTSPOTS_jfieldId == IntPtr.Zero)
						EVENT_PRELOADED_RIGHTSPOTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT_PRELOADED_RIGHTSPOTS", "Lcom/ironsrc/kudoskit/KudosKit$EventId;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EVENT_PRELOADED_RIGHTSPOTS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit.EventId> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EVENT_PRELOADED_RIGHTSPOTS_jfieldId == IntPtr.Zero)
						EVENT_PRELOADED_RIGHTSPOTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT_PRELOADED_RIGHTSPOTS", "Lcom/ironsrc/kudoskit/KudosKit$EventId;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EVENT_PRELOADED_RIGHTSPOTS_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EVENT_PURCHASE_SUCCESS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit.EventId']/field[@name='EVENT_PURCHASE_SUCCESS']"
			[Register ("EVENT_PURCHASE_SUCCESS")]
			public static global::Com.Ironsrc.Kudoskit.KudosKit.EventId EventPurchaseSuccess {
				get {
					if (EVENT_PURCHASE_SUCCESS_jfieldId == IntPtr.Zero)
						EVENT_PURCHASE_SUCCESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT_PURCHASE_SUCCESS", "Lcom/ironsrc/kudoskit/KudosKit$EventId;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EVENT_PURCHASE_SUCCESS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit.EventId> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EVENT_PURCHASE_SUCCESS_jfieldId == IntPtr.Zero)
						EVENT_PURCHASE_SUCCESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT_PURCHASE_SUCCESS", "Lcom/ironsrc/kudoskit/KudosKit$EventId;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EVENT_PURCHASE_SUCCESS_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EVENT_RIGHTSPOT_ENTER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit.EventId']/field[@name='EVENT_RIGHTSPOT_ENTER']"
			[Register ("EVENT_RIGHTSPOT_ENTER")]
			public static global::Com.Ironsrc.Kudoskit.KudosKit.EventId EventRightspotEnter {
				get {
					if (EVENT_RIGHTSPOT_ENTER_jfieldId == IntPtr.Zero)
						EVENT_RIGHTSPOT_ENTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT_RIGHTSPOT_ENTER", "Lcom/ironsrc/kudoskit/KudosKit$EventId;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EVENT_RIGHTSPOT_ENTER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit.EventId> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EVENT_RIGHTSPOT_ENTER_jfieldId == IntPtr.Zero)
						EVENT_RIGHTSPOT_ENTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT_RIGHTSPOT_ENTER", "Lcom/ironsrc/kudoskit/KudosKit$EventId;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EVENT_RIGHTSPOT_ENTER_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EVENT_RIGHTSPOT_EXIT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit.EventId']/field[@name='EVENT_RIGHTSPOT_EXIT']"
			[Register ("EVENT_RIGHTSPOT_EXIT")]
			public static global::Com.Ironsrc.Kudoskit.KudosKit.EventId EventRightspotExit {
				get {
					if (EVENT_RIGHTSPOT_EXIT_jfieldId == IntPtr.Zero)
						EVENT_RIGHTSPOT_EXIT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT_RIGHTSPOT_EXIT", "Lcom/ironsrc/kudoskit/KudosKit$EventId;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EVENT_RIGHTSPOT_EXIT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit.EventId> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EVENT_RIGHTSPOT_EXIT_jfieldId == IntPtr.Zero)
						EVENT_RIGHTSPOT_EXIT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT_RIGHTSPOT_EXIT", "Lcom/ironsrc/kudoskit/KudosKit$EventId;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EVENT_RIGHTSPOT_EXIT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EVENT_SYNC_ENTER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit.EventId']/field[@name='EVENT_SYNC_ENTER']"
			[Register ("EVENT_SYNC_ENTER")]
			public static global::Com.Ironsrc.Kudoskit.KudosKit.EventId EventSyncEnter {
				get {
					if (EVENT_SYNC_ENTER_jfieldId == IntPtr.Zero)
						EVENT_SYNC_ENTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT_SYNC_ENTER", "Lcom/ironsrc/kudoskit/KudosKit$EventId;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EVENT_SYNC_ENTER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit.EventId> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EVENT_SYNC_ENTER_jfieldId == IntPtr.Zero)
						EVENT_SYNC_ENTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT_SYNC_ENTER", "Lcom/ironsrc/kudoskit/KudosKit$EventId;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EVENT_SYNC_ENTER_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr EVENT_SYNC_EXIT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit.EventId']/field[@name='EVENT_SYNC_EXIT']"
			[Register ("EVENT_SYNC_EXIT")]
			public static global::Com.Ironsrc.Kudoskit.KudosKit.EventId EventSyncExit {
				get {
					if (EVENT_SYNC_EXIT_jfieldId == IntPtr.Zero)
						EVENT_SYNC_EXIT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT_SYNC_EXIT", "Lcom/ironsrc/kudoskit/KudosKit$EventId;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EVENT_SYNC_EXIT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit.EventId> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EVENT_SYNC_EXIT_jfieldId == IntPtr.Zero)
						EVENT_SYNC_EXIT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVENT_SYNC_EXIT", "Lcom/ironsrc/kudoskit/KudosKit$EventId;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EVENT_SYNC_EXIT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ironsrc/kudoskit/KudosKit$EventId", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (EventId); }
			}

			internal EventId (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit.EventId']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/ironsrc/kudoskit/KudosKit$EventId;", "")]
			public static global::Com.Ironsrc.Kudoskit.KudosKit.EventId ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/ironsrc/kudoskit/KudosKit$EventId;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Ironsrc.Kudoskit.KudosKit.EventId __ret = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit.EventId> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit.EventId']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/ironsrc/kudoskit/KudosKit$EventId;", "")]
			public static global::Com.Ironsrc.Kudoskit.KudosKit.EventId[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/ironsrc/kudoskit/KudosKit$EventId;");
				return (global::Com.Ironsrc.Kudoskit.KudosKit.EventId[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Ironsrc.Kudoskit.KudosKit.EventId));
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.ironsrc.kudoskit']/interface[@name='KudosKit.Listener']"
		[Register ("com/ironsrc/kudoskit/KudosKit$Listener", "", "Com.Ironsrc.Kudoskit.KudosKit/IListenerInvoker")]
		public partial interface IListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/interface[@name='KudosKit.Listener']/method[@name='onKudosKitEvent' and count(parameter)=2 and parameter[1][@type='com.ironsrc.kudoskit.KudosKit.EventId'] and parameter[2][@type='java.lang.Object']]"
			[Register ("onKudosKitEvent", "(Lcom/ironsrc/kudoskit/KudosKit$EventId;Ljava/lang/Object;)V", "GetOnKudosKitEvent_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_Handler:Com.Ironsrc.Kudoskit.KudosKit/IListenerInvoker, KudosKitBinding")]
			void OnKudosKitEvent (global::Com.Ironsrc.Kudoskit.KudosKit.EventId p0, global::Java.Lang.Object p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/interface[@name='KudosKit.Listener']/method[@name='rightspotCommand' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("rightspotCommand", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetRightspotCommand_Ljava_lang_String_Ljava_lang_String_Handler:Com.Ironsrc.Kudoskit.KudosKit/IListenerInvoker, KudosKitBinding")]
			bool RightspotCommand (string p0, string p1);

		}

		[global::Android.Runtime.Register ("com/ironsrc/kudoskit/KudosKit$Listener", DoNotGenerateAcw=true)]
		internal class IListenerInvoker : global::Java.Lang.Object, IListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/ironsrc/kudoskit/KudosKit$Listener");
			IntPtr class_ref;

			public static IListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.ironsrc.kudoskit.KudosKit.Listener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IListenerInvoker); }
			}

			static Delegate cb_onKudosKitEvent_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetOnKudosKitEvent_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_Handler ()
			{
				if (cb_onKudosKitEvent_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_ == null)
					cb_onKudosKitEvent_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnKudosKitEvent_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_);
				return cb_onKudosKitEvent_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_;
			}

			static void n_OnKudosKitEvent_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Ironsrc.Kudoskit.KudosKit.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Ironsrc.Kudoskit.KudosKit.EventId p0 = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit.EventId> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnKudosKitEvent (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onKudosKitEvent_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_;
			public void OnKudosKitEvent (global::Com.Ironsrc.Kudoskit.KudosKit.EventId p0, global::Java.Lang.Object p1)
			{
				if (id_onKudosKitEvent_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_ == IntPtr.Zero)
					id_onKudosKitEvent_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onKudosKitEvent", "(Lcom/ironsrc/kudoskit/KudosKit$EventId;Ljava/lang/Object;)V");
				JNIEnv.CallVoidMethod (Handle, id_onKudosKitEvent_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_, new JValue (p0), new JValue (p1));
			}

			static Delegate cb_rightspotCommand_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetRightspotCommand_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_rightspotCommand_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_rightspotCommand_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_RightspotCommand_Ljava_lang_String_Ljava_lang_String_);
				return cb_rightspotCommand_Ljava_lang_String_Ljava_lang_String_;
			}

			static bool n_RightspotCommand_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Ironsrc.Kudoskit.KudosKit.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.RightspotCommand (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_rightspotCommand_Ljava_lang_String_Ljava_lang_String_;
			public bool RightspotCommand (string p0, string p1)
			{
				if (id_rightspotCommand_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_rightspotCommand_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "rightspotCommand", "(Ljava/lang/String;Ljava/lang/String;)Z");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				bool __ret = JNIEnv.CallBooleanMethod (Handle, id_rightspotCommand_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				return __ret;
			}

		}

		public partial class KudosKitEventEventArgs : global::System.EventArgs {

			public KudosKitEventEventArgs (global::Com.Ironsrc.Kudoskit.KudosKit.EventId p0, global::Java.Lang.Object p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Ironsrc.Kudoskit.KudosKit.EventId p0;
			public global::Com.Ironsrc.Kudoskit.KudosKit.EventId P0 {
				get { return p0; }
			}

			global::Java.Lang.Object p1;
			public global::Java.Lang.Object P1 {
				get { return p1; }
			}
		}

		public partial class RightspotCommandEventArgs : global::System.EventArgs {

			public RightspotCommandEventArgs (bool handled, string p0, string p1)
			{
				this.handled = handled;
				this.p0 = p0;
				this.p1 = p1;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			string p0;
			public string P0 {
				get { return p0; }
			}

			string p1;
			public string P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/ironsrc/kudoskit/KudosKit_ListenerImplementor")]
		internal sealed class IListenerImplementor : global::Java.Lang.Object, IListener {

			object sender;

			public IListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/ironsrc/kudoskit/KudosKit_ListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<KudosKitEventEventArgs> OnKudosKitEventHandler;
#pragma warning restore 0649

			public void OnKudosKitEvent (global::Com.Ironsrc.Kudoskit.KudosKit.EventId p0, global::Java.Lang.Object p1)
			{
				var __h = OnKudosKitEventHandler;
				if (__h != null)
					__h (sender, new KudosKitEventEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<RightspotCommandEventArgs> RightspotCommandHandler;
#pragma warning restore 0649

			public bool RightspotCommand (string p0, string p1)
			{
				var __h = RightspotCommandHandler;
				if (__h == null)
					return false;
				var __e = new RightspotCommandEventArgs (true, p0, p1);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IListenerImplementor value)
			{
				return value.OnKudosKitEventHandler == null && value.RightspotCommandHandler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ironsrc/kudoskit/KudosKit", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KudosKit); }
		}

		protected KudosKit (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/constructor[@name='KudosKit' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public KudosKit (global::Android.Content.Context p0, string p1, string p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			if (GetType () != typeof (KudosKit)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1), new JValue (native_p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1), new JValue (native_p2));
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				return;
			}

			if (id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_getAppId;
#pragma warning disable 0169
		static Delegate GetGetAppIdHandler ()
		{
			if (cb_getAppId == null)
				cb_getAppId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppId);
			return cb_getAppId;
		}

		static IntPtr n_GetAppId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppId);
		}
#pragma warning restore 0169

		static IntPtr id_getAppId;
		protected virtual string AppId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='getAppId' and count(parameter)=0]"
			[Register ("getAppId", "()Ljava/lang/String;", "GetGetAppIdHandler")]
			get {
				if (id_getAppId == IntPtr.Zero)
					id_getAppId = JNIEnv.GetMethodID (class_ref, "getAppId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAppId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getFeatures;
#pragma warning disable 0169
		static Delegate GetGetFeaturesHandler ()
		{
			if (cb_getFeatures == null)
				cb_getFeatures = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFeatures);
			return cb_getFeatures;
		}

		static IntPtr n_GetFeatures (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.Features);
		}
#pragma warning restore 0169

		static IntPtr id_getFeatures;
		public virtual global::System.Collections.Generic.IList<string> Features {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='getFeatures' and count(parameter)=0]"
			[Register ("getFeatures", "()Ljava/util/List;", "GetGetFeaturesHandler")]
			get {
				if (id_getFeatures == IntPtr.Zero)
					id_getFeatures = JNIEnv.GetMethodID (class_ref, "getFeatures", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getFeatures), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFeatures", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isConnected;
#pragma warning disable 0169
		static Delegate GetIsConnectedHandler ()
		{
			if (cb_isConnected == null)
				cb_isConnected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConnected);
			return cb_isConnected;
		}

		static bool n_IsConnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		static IntPtr id_isConnected;
		protected virtual bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")]
			get {
				if (id_isConnected == IntPtr.Zero)
					id_isConnected = JNIEnv.GetMethodID (class_ref, "isConnected", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isConnected);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isConnected", "()Z"));
			}
		}

		static Delegate cb_isKeyValid;
#pragma warning disable 0169
		static Delegate GetIsKeyValidHandler ()
		{
			if (cb_isKeyValid == null)
				cb_isKeyValid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsKeyValid);
			return cb_isKeyValid;
		}

		static bool n_IsKeyValid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsKeyValid;
		}
#pragma warning restore 0169

		static IntPtr id_isKeyValid;
		public virtual bool IsKeyValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='isKeyValid' and count(parameter)=0]"
			[Register ("isKeyValid", "()Z", "GetIsKeyValidHandler")]
			get {
				if (id_isKeyValid == IntPtr.Zero)
					id_isKeyValid = JNIEnv.GetMethodID (class_ref, "isKeyValid", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isKeyValid);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isKeyValid", "()Z"));
			}
		}

		static Delegate cb_getMajorVersion;
#pragma warning disable 0169
		static Delegate GetGetMajorVersionHandler ()
		{
			if (cb_getMajorVersion == null)
				cb_getMajorVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMajorVersion);
			return cb_getMajorVersion;
		}

		static int n_GetMajorVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MajorVersion;
		}
#pragma warning restore 0169

		static IntPtr id_getMajorVersion;
		public virtual int MajorVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='getMajorVersion' and count(parameter)=0]"
			[Register ("getMajorVersion", "()I", "GetGetMajorVersionHandler")]
			get {
				if (id_getMajorVersion == IntPtr.Zero)
					id_getMajorVersion = JNIEnv.GetMethodID (class_ref, "getMajorVersion", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getMajorVersion);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMajorVersion", "()I"));
			}
		}

		static Delegate cb_getMinorVersion;
#pragma warning disable 0169
		static Delegate GetGetMinorVersionHandler ()
		{
			if (cb_getMinorVersion == null)
				cb_getMinorVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMinorVersion);
			return cb_getMinorVersion;
		}

		static int n_GetMinorVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinorVersion;
		}
#pragma warning restore 0169

		static IntPtr id_getMinorVersion;
		public virtual int MinorVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='getMinorVersion' and count(parameter)=0]"
			[Register ("getMinorVersion", "()I", "GetGetMinorVersionHandler")]
			get {
				if (id_getMinorVersion == IntPtr.Zero)
					id_getMinorVersion = JNIEnv.GetMethodID (class_ref, "getMinorVersion", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getMinorVersion);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinorVersion", "()I"));
			}
		}

		static Delegate cb_getRevision;
#pragma warning disable 0169
		static Delegate GetGetRevisionHandler ()
		{
			if (cb_getRevision == null)
				cb_getRevision = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRevision);
			return cb_getRevision;
		}

		static int n_GetRevision (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Revision;
		}
#pragma warning restore 0169

		static IntPtr id_getRevision;
		public virtual int Revision {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='getRevision' and count(parameter)=0]"
			[Register ("getRevision", "()I", "GetGetRevisionHandler")]
			get {
				if (id_getRevision == IntPtr.Zero)
					id_getRevision = JNIEnv.GetMethodID (class_ref, "getRevision", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getRevision);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRevision", "()I"));
			}
		}

		static Delegate cb_getVersionString;
#pragma warning disable 0169
		static Delegate GetGetVersionStringHandler ()
		{
			if (cb_getVersionString == null)
				cb_getVersionString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVersionString);
			return cb_getVersionString;
		}

		static IntPtr n_GetVersionString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VersionString);
		}
#pragma warning restore 0169

		static IntPtr id_getVersionString;
		public virtual string VersionString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='getVersionString' and count(parameter)=0]"
			[Register ("getVersionString", "()Ljava/lang/String;", "GetGetVersionStringHandler")]
			get {
				if (id_getVersionString == IntPtr.Zero)
					id_getVersionString = JNIEnv.GetMethodID (class_ref, "getVersionString", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getVersionString), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVersionString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addListener_Lcom_ironsrc_kudoskit_KudosKit_Listener_;
#pragma warning disable 0169
		static Delegate GetAddListener_Lcom_ironsrc_kudoskit_KudosKit_Listener_Handler ()
		{
			if (cb_addListener_Lcom_ironsrc_kudoskit_KudosKit_Listener_ == null)
				cb_addListener_Lcom_ironsrc_kudoskit_KudosKit_Listener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddListener_Lcom_ironsrc_kudoskit_KudosKit_Listener_);
			return cb_addListener_Lcom_ironsrc_kudoskit_KudosKit_Listener_;
		}

		static void n_AddListener_Lcom_ironsrc_kudoskit_KudosKit_Listener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Ironsrc.Kudoskit.KudosKit.IListener p0 = (global::Com.Ironsrc.Kudoskit.KudosKit.IListener)global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit.IListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addListener_Lcom_ironsrc_kudoskit_KudosKit_Listener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='addListener' and count(parameter)=1 and parameter[1][@type='com.ironsrc.kudoskit.KudosKit.Listener']]"
		[Register ("addListener", "(Lcom/ironsrc/kudoskit/KudosKit$Listener;)V", "GetAddListener_Lcom_ironsrc_kudoskit_KudosKit_Listener_Handler")]
		public virtual void AddListener (global::Com.Ironsrc.Kudoskit.KudosKit.IListener p0)
		{
			if (id_addListener_Lcom_ironsrc_kudoskit_KudosKit_Listener_ == IntPtr.Zero)
				id_addListener_Lcom_ironsrc_kudoskit_KudosKit_Listener_ = JNIEnv.GetMethodID (class_ref, "addListener", "(Lcom/ironsrc/kudoskit/KudosKit$Listener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addListener_Lcom_ironsrc_kudoskit_KudosKit_Listener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addListener", "(Lcom/ironsrc/kudoskit/KudosKit$Listener;)V"), new JValue (p0));
		}

		static Delegate cb_counterSetEvent_Ljava_lang_String_D;
#pragma warning disable 0169
		static Delegate GetCounterSetEvent_Ljava_lang_String_DHandler ()
		{
			if (cb_counterSetEvent_Ljava_lang_String_D == null)
				cb_counterSetEvent_Ljava_lang_String_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, double>) n_CounterSetEvent_Ljava_lang_String_D);
			return cb_counterSetEvent_Ljava_lang_String_D;
		}

		static void n_CounterSetEvent_Ljava_lang_String_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CounterSetEvent (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_counterSetEvent_Ljava_lang_String_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='counterSetEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double']]"
		[Register ("counterSetEvent", "(Ljava/lang/String;D)V", "GetCounterSetEvent_Ljava_lang_String_DHandler")]
		public virtual void CounterSetEvent (string p0, double p1)
		{
			if (id_counterSetEvent_Ljava_lang_String_D == IntPtr.Zero)
				id_counterSetEvent_Ljava_lang_String_D = JNIEnv.GetMethodID (class_ref, "counterSetEvent", "(Ljava/lang/String;D)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_counterSetEvent_Ljava_lang_String_D, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "counterSetEvent", "(Ljava/lang/String;D)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_counterUpdateEvent_Ljava_lang_String_D;
#pragma warning disable 0169
		static Delegate GetCounterUpdateEvent_Ljava_lang_String_DHandler ()
		{
			if (cb_counterUpdateEvent_Ljava_lang_String_D == null)
				cb_counterUpdateEvent_Ljava_lang_String_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, double>) n_CounterUpdateEvent_Ljava_lang_String_D);
			return cb_counterUpdateEvent_Ljava_lang_String_D;
		}

		static void n_CounterUpdateEvent_Ljava_lang_String_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CounterUpdateEvent (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_counterUpdateEvent_Ljava_lang_String_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='counterUpdateEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double']]"
		[Register ("counterUpdateEvent", "(Ljava/lang/String;D)V", "GetCounterUpdateEvent_Ljava_lang_String_DHandler")]
		public virtual void CounterUpdateEvent (string p0, double p1)
		{
			if (id_counterUpdateEvent_Ljava_lang_String_D == IntPtr.Zero)
				id_counterUpdateEvent_Ljava_lang_String_D = JNIEnv.GetMethodID (class_ref, "counterUpdateEvent", "(Ljava/lang/String;D)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_counterUpdateEvent_Ljava_lang_String_D, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "counterUpdateEvent", "(Ljava/lang/String;D)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_debug;
#pragma warning disable 0169
		static Delegate GetDebugHandler ()
		{
			if (cb_debug == null)
				cb_debug = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Debug);
			return cb_debug;
		}

		static void n_Debug (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Debug ();
		}
#pragma warning restore 0169

		static IntPtr id_debug;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='debug' and count(parameter)=0]"
		[Register ("debug", "()V", "GetDebugHandler")]
		public virtual void Debug ()
		{
			if (id_debug == IntPtr.Zero)
				id_debug = JNIEnv.GetMethodID (class_ref, "debug", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_debug);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "debug", "()V"));
		}

		static Delegate cb_developerEvent;
#pragma warning disable 0169
		static Delegate GetDeveloperEventHandler ()
		{
			if (cb_developerEvent == null)
				cb_developerEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DeveloperEvent);
			return cb_developerEvent;
		}

		static void n_DeveloperEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeveloperEvent ();
		}
#pragma warning restore 0169

		static IntPtr id_developerEvent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='developerEvent' and count(parameter)=0]"
		[Register ("developerEvent", "()V", "GetDeveloperEventHandler")]
		public virtual void DeveloperEvent ()
		{
			if (id_developerEvent == IntPtr.Zero)
				id_developerEvent = JNIEnv.GetMethodID (class_ref, "developerEvent", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_developerEvent);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "developerEvent", "()V"));
		}

		static Delegate cb_durationEndEvent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDurationEndEvent_Ljava_lang_String_Handler ()
		{
			if (cb_durationEndEvent_Ljava_lang_String_ == null)
				cb_durationEndEvent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DurationEndEvent_Ljava_lang_String_);
			return cb_durationEndEvent_Ljava_lang_String_;
		}

		static void n_DurationEndEvent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DurationEndEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_durationEndEvent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='durationEndEvent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("durationEndEvent", "(Ljava/lang/String;)V", "GetDurationEndEvent_Ljava_lang_String_Handler")]
		public virtual void DurationEndEvent (string p0)
		{
			if (id_durationEndEvent_Ljava_lang_String_ == IntPtr.Zero)
				id_durationEndEvent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "durationEndEvent", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_durationEndEvent_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "durationEndEvent", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_durationStartEvent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDurationStartEvent_Ljava_lang_String_Handler ()
		{
			if (cb_durationStartEvent_Ljava_lang_String_ == null)
				cb_durationStartEvent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DurationStartEvent_Ljava_lang_String_);
			return cb_durationStartEvent_Ljava_lang_String_;
		}

		static void n_DurationStartEvent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DurationStartEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_durationStartEvent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='durationStartEvent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("durationStartEvent", "(Ljava/lang/String;)V", "GetDurationStartEvent_Ljava_lang_String_Handler")]
		public virtual void DurationStartEvent (string p0)
		{
			if (id_durationStartEvent_Ljava_lang_String_ == IntPtr.Zero)
				id_durationStartEvent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "durationStartEvent", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_durationStartEvent_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "durationStartEvent", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_formatPrice_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='formatPrice' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("formatPrice", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		protected static string FormatPrice (string p0)
		{
			if (id_formatPrice_Ljava_lang_String_ == IntPtr.Zero)
				id_formatPrice_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "formatPrice", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_formatPrice_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getInternalBundleName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetInternalBundleName_Ljava_lang_String_Handler ()
		{
			if (cb_getInternalBundleName_Ljava_lang_String_ == null)
				cb_getInternalBundleName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetInternalBundleName_Ljava_lang_String_);
			return cb_getInternalBundleName_Ljava_lang_String_;
		}

		static IntPtr n_GetInternalBundleName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetInternalBundleName (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getInternalBundleName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='getInternalBundleName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getInternalBundleName", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetInternalBundleName_Ljava_lang_String_Handler")]
		protected virtual string GetInternalBundleName (string p0)
		{
			if (id_getInternalBundleName_Ljava_lang_String_ == IntPtr.Zero)
				id_getInternalBundleName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getInternalBundleName", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getInternalBundleName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInternalBundleName", "(Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_instance;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='instance' and count(parameter)=0]"
		[Register ("instance", "()Lcom/ironsrc/kudoskit/KudosKit;", "")]
		public static global::Com.Ironsrc.Kudoskit.KudosKit Instance ()
		{
			if (id_instance == IntPtr.Zero)
				id_instance = JNIEnv.GetStaticMethodID (class_ref, "instance", "()Lcom/ironsrc/kudoskit/KudosKit;");
			return global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (JNIEnv.CallStaticObjectMethod  (class_ref, id_instance), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_isRightspot_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsRightspot_Ljava_lang_String_Handler ()
		{
			if (cb_isRightspot_Ljava_lang_String_ == null)
				cb_isRightspot_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsRightspot_Ljava_lang_String_);
			return cb_isRightspot_Ljava_lang_String_;
		}

		static bool n_IsRightspot_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsRightspot (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isRightspot_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='isRightspot' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isRightspot", "(Ljava/lang/String;)Z", "GetIsRightspot_Ljava_lang_String_Handler")]
		public virtual bool IsRightspot (string p0)
		{
			if (id_isRightspot_Ljava_lang_String_ == IntPtr.Zero)
				id_isRightspot_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isRightspot", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_isRightspot_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRightspot", "(Ljava/lang/String;)Z"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_notifyListeners_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetNotifyListeners_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_Handler ()
		{
			if (cb_notifyListeners_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_ == null)
				cb_notifyListeners_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_NotifyListeners_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_);
			return cb_notifyListeners_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_;
		}

		static void n_NotifyListeners_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Ironsrc.Kudoskit.KudosKit.EventId p0 = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit.EventId> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.NotifyListeners (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_notifyListeners_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='notifyListeners' and count(parameter)=2 and parameter[1][@type='com.ironsrc.kudoskit.KudosKit.EventId'] and parameter[2][@type='java.lang.Object']]"
		[Register ("notifyListeners", "(Lcom/ironsrc/kudoskit/KudosKit$EventId;Ljava/lang/Object;)V", "GetNotifyListeners_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_Handler")]
		protected virtual void NotifyListeners (global::Com.Ironsrc.Kudoskit.KudosKit.EventId p0, global::Java.Lang.Object p1)
		{
			if (id_notifyListeners_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_ == IntPtr.Zero)
				id_notifyListeners_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "notifyListeners", "(Lcom/ironsrc/kudoskit/KudosKit$EventId;Ljava/lang/Object;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_notifyListeners_Lcom_ironsrc_kudoskit_KudosKit_EventId_Ljava_lang_Object_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyListeners", "(Lcom/ironsrc/kudoskit/KudosKit$EventId;Ljava/lang/Object;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_notifyRightspotCommand_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNotifyRightspotCommand_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_notifyRightspotCommand_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_notifyRightspotCommand_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_NotifyRightspotCommand_Ljava_lang_String_Ljava_lang_String_);
			return cb_notifyRightspotCommand_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_NotifyRightspotCommand_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.NotifyRightspotCommand (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_notifyRightspotCommand_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='notifyRightspotCommand' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("notifyRightspotCommand", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetNotifyRightspotCommand_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual bool NotifyRightspotCommand (string p0, string p1)
		{
			if (id_notifyRightspotCommand_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_notifyRightspotCommand_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "notifyRightspotCommand", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_notifyRightspotCommand_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyRightspotCommand", "(Ljava/lang/String;Ljava/lang/String;)Z"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_onDestroy;
#pragma warning disable 0169
		static Delegate GetOnDestroyHandler ()
		{
			if (cb_onDestroy == null)
				cb_onDestroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDestroy);
			return cb_onDestroy;
		}

		static void n_OnDestroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		static IntPtr id_onDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler")]
		public virtual void OnDestroy ()
		{
			if (id_onDestroy == IntPtr.Zero)
				id_onDestroy = JNIEnv.GetMethodID (class_ref, "onDestroy", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onDestroy);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDestroy", "()V"));
		}

		static Delegate cb_onStart;
#pragma warning disable 0169
		static Delegate GetOnStartHandler ()
		{
			if (cb_onStart == null)
				cb_onStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStart);
			return cb_onStart;
		}

		static void n_OnStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStart ();
		}
#pragma warning restore 0169

		static IntPtr id_onStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='onStart' and count(parameter)=0]"
		[Register ("onStart", "()V", "GetOnStartHandler")]
		public virtual void OnStart ()
		{
			if (id_onStart == IntPtr.Zero)
				id_onStart = JNIEnv.GetMethodID (class_ref, "onStart", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onStart);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStart", "()V"));
		}

		static Delegate cb_onStop;
#pragma warning disable 0169
		static Delegate GetOnStopHandler ()
		{
			if (cb_onStop == null)
				cb_onStop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStop);
			return cb_onStop;
		}

		static void n_OnStop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStop ();
		}
#pragma warning restore 0169

		static IntPtr id_onStop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='onStop' and count(parameter)=0]"
		[Register ("onStop", "()V", "GetOnStopHandler")]
		public virtual void OnStop ()
		{
			if (id_onStop == IntPtr.Zero)
				id_onStop = JNIEnv.GetMethodID (class_ref, "onStop", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onStop);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStop", "()V"));
		}

		static Delegate cb_purchaseEvent_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPurchaseEvent_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_purchaseEvent_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_purchaseEvent_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PurchaseEvent_Ljava_lang_String_Ljava_lang_String_);
			return cb_purchaseEvent_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_PurchaseEvent_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PurchaseEvent (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_purchaseEvent_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='purchaseEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("purchaseEvent", "(Ljava/lang/String;Ljava/lang/String;)V", "GetPurchaseEvent_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual void PurchaseEvent (string p0, string p1)
		{
			if (id_purchaseEvent_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_purchaseEvent_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "purchaseEvent", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_purchaseEvent_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "purchaseEvent", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_recordEvent_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRecordEvent_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_recordEvent_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_recordEvent_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RecordEvent_Ljava_lang_String_Ljava_lang_String_);
			return cb_recordEvent_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_RecordEvent_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RecordEvent (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_recordEvent_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='recordEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("recordEvent", "(Ljava/lang/String;Ljava/lang/String;)V", "GetRecordEvent_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void RecordEvent (string p0, string p1)
		{
			if (id_recordEvent_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_recordEvent_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "recordEvent", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_recordEvent_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "recordEvent", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_removeListener_Lcom_ironsrc_kudoskit_KudosKit_Listener_;
#pragma warning disable 0169
		static Delegate GetRemoveListener_Lcom_ironsrc_kudoskit_KudosKit_Listener_Handler ()
		{
			if (cb_removeListener_Lcom_ironsrc_kudoskit_KudosKit_Listener_ == null)
				cb_removeListener_Lcom_ironsrc_kudoskit_KudosKit_Listener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveListener_Lcom_ironsrc_kudoskit_KudosKit_Listener_);
			return cb_removeListener_Lcom_ironsrc_kudoskit_KudosKit_Listener_;
		}

		static void n_RemoveListener_Lcom_ironsrc_kudoskit_KudosKit_Listener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Ironsrc.Kudoskit.KudosKit.IListener p0 = (global::Com.Ironsrc.Kudoskit.KudosKit.IListener)global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit.IListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeListener_Lcom_ironsrc_kudoskit_KudosKit_Listener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='removeListener' and count(parameter)=1 and parameter[1][@type='com.ironsrc.kudoskit.KudosKit.Listener']]"
		[Register ("removeListener", "(Lcom/ironsrc/kudoskit/KudosKit$Listener;)V", "GetRemoveListener_Lcom_ironsrc_kudoskit_KudosKit_Listener_Handler")]
		public virtual void RemoveListener (global::Com.Ironsrc.Kudoskit.KudosKit.IListener p0)
		{
			if (id_removeListener_Lcom_ironsrc_kudoskit_KudosKit_Listener_ == IntPtr.Zero)
				id_removeListener_Lcom_ironsrc_kudoskit_KudosKit_Listener_ = JNIEnv.GetMethodID (class_ref, "removeListener", "(Lcom/ironsrc/kudoskit/KudosKit$Listener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeListener_Lcom_ironsrc_kudoskit_KudosKit_Listener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeListener", "(Lcom/ironsrc/kudoskit/KudosKit$Listener;)V"), new JValue (p0));
		}

		static Delegate cb_rightspotEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRightspotEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_rightspotEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_rightspotEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RightspotEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_rightspotEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_RightspotEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.RightspotEvent (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_rightspotEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='rightspotEvent' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("rightspotEvent", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetRightspotEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual void RightspotEvent (string p0, string p1, string p2, string p3)
		{
			if (id_rightspotEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_rightspotEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "rightspotEvent", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_rightspotEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rightspotEvent", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static IntPtr id_setQuiet_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='setQuiet' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setQuiet", "(Z)V", "")]
		public static void SetQuiet (bool p0)
		{
			if (id_setQuiet_Z == IntPtr.Zero)
				id_setQuiet_Z = JNIEnv.GetStaticMethodID (class_ref, "setQuiet", "(Z)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setQuiet_Z, new JValue (p0));
		}

		static Delegate cb_setSyncURL_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSyncURL_Ljava_lang_String_Handler ()
		{
			if (cb_setSyncURL_Ljava_lang_String_ == null)
				cb_setSyncURL_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSyncURL_Ljava_lang_String_);
			return cb_setSyncURL_Ljava_lang_String_;
		}

		static void n_SetSyncURL_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSyncURL (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSyncURL_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='setSyncURL' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setSyncURL", "(Ljava/lang/String;)V", "GetSetSyncURL_Ljava_lang_String_Handler")]
		public virtual void SetSyncURL (string p0)
		{
			if (id_setSyncURL_Ljava_lang_String_ == IntPtr.Zero)
				id_setSyncURL_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSyncURL", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setSyncURL_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSyncURL", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setup_arrayLjava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetup_arrayLjava_lang_String_arrayLjava_lang_String_Handler ()
		{
			if (cb_setup_arrayLjava_lang_String_arrayLjava_lang_String_ == null)
				cb_setup_arrayLjava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Setup_arrayLjava_lang_String_arrayLjava_lang_String_);
			return cb_setup_arrayLjava_lang_String_arrayLjava_lang_String_;
		}

		static void n_Setup_arrayLjava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.Setup (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_setup_arrayLjava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='setup' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("setup", "([Ljava/lang/String;[Ljava/lang/String;)V", "GetSetup_arrayLjava_lang_String_arrayLjava_lang_String_Handler")]
		public virtual void Setup (string[] p0, string[] p1)
		{
			if (id_setup_arrayLjava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_setup_arrayLjava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setup", "([Ljava/lang/String;[Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setup_arrayLjava_lang_String_arrayLjava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setup", "([Ljava/lang/String;[Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_shareEvent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetShareEvent_Ljava_lang_String_Handler ()
		{
			if (cb_shareEvent_Ljava_lang_String_ == null)
				cb_shareEvent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShareEvent_Ljava_lang_String_);
			return cb_shareEvent_Ljava_lang_String_;
		}

		static void n_ShareEvent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShareEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_shareEvent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='shareEvent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("shareEvent", "(Ljava/lang/String;)V", "GetShareEvent_Ljava_lang_String_Handler")]
		public virtual void ShareEvent (string p0)
		{
			if (id_shareEvent_Ljava_lang_String_ == IntPtr.Zero)
				id_shareEvent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "shareEvent", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_shareEvent_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shareEvent", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_shareEvent_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetShareEvent_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_shareEvent_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_shareEvent_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ShareEvent_Ljava_lang_String_Ljava_lang_String_);
			return cb_shareEvent_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_ShareEvent_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ShareEvent (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_shareEvent_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='shareEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("shareEvent", "(Ljava/lang/String;Ljava/lang/String;)V", "GetShareEvent_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void ShareEvent (string p0, string p1)
		{
			if (id_shareEvent_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_shareEvent_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "shareEvent", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_shareEvent_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shareEvent", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_startRightspot;
#pragma warning disable 0169
		static Delegate GetStartRightspotHandler ()
		{
			if (cb_startRightspot == null)
				cb_startRightspot = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_StartRightspot);
			return cb_startRightspot;
		}

		static bool n_StartRightspot (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartRightspot ();
		}
#pragma warning restore 0169

		static IntPtr id_startRightspot;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='startRightspot' and count(parameter)=0]"
		[Register ("startRightspot", "()Z", "GetStartRightspotHandler")]
		public virtual bool StartRightspot ()
		{
			if (id_startRightspot == IntPtr.Zero)
				id_startRightspot = JNIEnv.GetMethodID (class_ref, "startRightspot", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_startRightspot);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startRightspot", "()Z"));
		}

		static Delegate cb_startRightspot_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStartRightspot_Ljava_lang_String_Handler ()
		{
			if (cb_startRightspot_Ljava_lang_String_ == null)
				cb_startRightspot_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_StartRightspot_Ljava_lang_String_);
			return cb_startRightspot_Ljava_lang_String_;
		}

		static bool n_StartRightspot_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StartRightspot (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_startRightspot_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='startRightspot' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("startRightspot", "(Ljava/lang/String;)Z", "GetStartRightspot_Ljava_lang_String_Handler")]
		public virtual bool StartRightspot (string p0)
		{
			if (id_startRightspot_Ljava_lang_String_ == IntPtr.Zero)
				id_startRightspot_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "startRightspot", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_startRightspot_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startRightspot", "(Ljava/lang/String;)Z"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_startRightspot_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetStartRightspot_Ljava_lang_String_IHandler ()
		{
			if (cb_startRightspot_Ljava_lang_String_I == null)
				cb_startRightspot_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, bool>) n_StartRightspot_Ljava_lang_String_I);
			return cb_startRightspot_Ljava_lang_String_I;
		}

		static bool n_StartRightspot_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Ironsrc.Kudoskit.KudosKit __this = global::Java.Lang.Object.GetObject<global::Com.Ironsrc.Kudoskit.KudosKit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StartRightspot (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_startRightspot_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='startRightspot' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("startRightspot", "(Ljava/lang/String;I)Z", "GetStartRightspot_Ljava_lang_String_IHandler")]
		public virtual bool StartRightspot (string p0, int p1)
		{
			if (id_startRightspot_Ljava_lang_String_I == IntPtr.Zero)
				id_startRightspot_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "startRightspot", "(Ljava/lang/String;I)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_startRightspot_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startRightspot", "(Ljava/lang/String;I)Z"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_whine_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='whine' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("whine", "(ILjava/lang/String;)V", "")]
		public static void Whine (int p0, string p1)
		{
			if (id_whine_ILjava_lang_String_ == IntPtr.Zero)
				id_whine_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "whine", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_whine_ILjava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_whine_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ironsrc.kudoskit']/class[@name='KudosKit']/method[@name='whine' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("whine", "(Ljava/lang/String;)V", "")]
		public static void Whine (string p0)
		{
			if (id_whine_Ljava_lang_String_ == IntPtr.Zero)
				id_whine_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "whine", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_whine_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

#region "Event implementation for Com.Ironsrc.Kudoskit.KudosKit.IListener"

		global::Com.Ironsrc.Kudoskit.KudosKit.IListenerImplementor __CreateIListenerImplementor ()
		{
			return new global::Com.Ironsrc.Kudoskit.KudosKit.IListenerImplementor (this);
		}
#endregion
	}
}
